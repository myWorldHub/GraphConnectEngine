using System;
using System.Collections.Generic;
using System.Reflection;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class StaticMethodGraph : GraphBase
    {

        private MethodInfo _methodInfo;
        private ParameterInfo[] _parameters;

        private readonly List<InItemNode> _inItemNodes = new List<InItemNode>();
        private readonly List<OutItemNode> _outItemNodes = new List<OutItemNode>();

        public StaticMethodGraph(NodeConnector connector, MethodInfo methodInfo,bool streamItem = false)
        {
            if (methodInfo == null || !methodInfo.IsStatic || !methodInfo.IsPublic)
                return;

            _methodInfo = methodInfo;

            _parameters = methodInfo.GetParameters();
            foreach(ParameterInfo parameterInfo in _parameters)
            {
                InItemNode iNode = new InItemNode(this, connector, parameterInfo.ParameterType);
                _inItemNodes.Add(iNode);
            }

            Type ret = _methodInfo.ReturnType;
            if (ret != typeof(Void))
            {
                _outItemNodes.Add(new OutItemNode(this,connector,ret, InvokeMethod));
            }
        }

        private object InvokeMethod()
        {

            object[] param = new object[_parameters.Length];
            for (int i=0;i<_parameters.Length;i++)
            {
                ParameterInfo parameterInfo = _parameters[i];
                if (_inItemNodes[i].Connector.TryGetAnotherNode(_inItemNodes[i], out OutItemNode resolver))
                {
                    if (resolver.TryGetValue(out object oitem))
                    {
                        param[i] = oitem;
                        continue;
                    }
                }

                if (parameterInfo.HasDefaultValue)
                {
                    param[i] = parameterInfo.DefaultValue;
                }
                else
                {
                    return null;//TODO 失敗
                }
            }

            var result = _methodInfo.Invoke(null, param);
            return result; 
        }

        /// <summary>
        /// 生成されたInItemNodeのリストを取得する
        /// </summary>
        /// <returns></returns>
        public InItemNode[] GetInItemNodes()
        {
            return _inItemNodes.ToArray();
        }

        /// <summary>
        /// 生成されたOutItemNodeのリストを取得する
        /// </summary>
        /// <returns></returns>
        public OutItemNode[] GetOutItemNodes()
        {
            return _outItemNodes.ToArray();
        }

        /// <summary>
        /// 返り値があるかどうかを取得する
        /// </summary>
        /// <returns></returns>
        public bool HasReturnValue()
        {
            return _methodInfo.ReturnType != typeof(Void);
        }

        public override string GetGraphName()
        {
            if (_methodInfo != null)
            {
                return "<" + _methodInfo.Name + "> Graph";
            }
            return "Direct Method Graph";
        }
    }
}
