using System;
using System.Collections.Generic;
using System.Reflection;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public abstract class GenerativeGraph : GraphBase
    {

        public MethodInfo MethodInfo { get; }

        protected ParameterInfo[] Parameters;

        protected readonly List<InItemNode> InItemNodes = new List<InItemNode>();
        
        protected readonly List<OutItemNode> OutItemNodes = new List<OutItemNode>();

        protected readonly OutItemNode OutResultNode;
        

        public GenerativeGraph(NodeConnector connector, MethodInfo methodInfo,bool streamItem = false) : base(connector)
        {
            if (methodInfo == null || !methodInfo.IsPublic)
                return;//TODO Exception
            
            MethodInfo = methodInfo;

            //Return Node
            OutResultNode = new OutItemNode(this, connector, MethodInfo.ReturnType, InvokeMethod);
            
            //Parameter
            Parameters = MethodInfo.GetParameters();
            for(int i=0;i<Parameters.Length;i++)
            {
                ParameterInfo parameterInfo = Parameters[i];
                InItemNode iNode = new InItemNode(this, connector, parameterInfo.ParameterType);
                InItemNodes.Add(iNode);

                if (streamItem)
                {
                    //TODO
                    //OutItemNode oNode = new OutItemNode(this, connector, parameterInfo.ParameterType,()=>GetValue(i));
                }
            }

        }
        
        /// <summary>
        /// パラメーターにあたるノードからあたいをとってくる
        /// </summary>
        /// <param name="result">結果</param>
        /// <returns>成功したかどうか</returns>
        protected bool TryGetParameterValues(ProcessCallArgs args,out object[] result)
        {
            object[] param = new object[Parameters.Length];
            
            for (int i = 0; i < Parameters.Length; i++)
            {
                ParameterInfo parameterInfo = Parameters[i];
                if (InItemNodes[i].GetItemFromConnectedNode(args, out object oitem))
                {
                    param[i] = oitem;
                    continue;
                }
                
                if (parameterInfo.HasDefaultValue)
                {
                    param[i] = parameterInfo.DefaultValue;
                }
                else
                {
                    result = null;
                    return false;
                }
            }

            result = param;
            return true;
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out OutProcessNode nextNode)
        {
            nextNode = OutProcessNode;
            return OutResultNode.TryGetValue(args, out object t);
        }

        /// <summary>
        /// 実行する
        /// </summary>
        /// <returns></returns>
        protected abstract bool InvokeMethod(ProcessCallArgs args,out object result);

        /// <summary>
        /// 生成されたInItemNodeのリストを取得する
        /// </summary>
        /// <returns></returns>
        public InItemNode[] GetInItemNodes()
        {
            return InItemNodes.ToArray();
        }

        /// <summary>
        /// 生成されたOutItemNodeのリストを取得する
        /// </summary>
        /// <returns></returns>
        public OutItemNode[] GetOutItemNodes()
        {
            return OutItemNodes.ToArray();
        }

    }
}