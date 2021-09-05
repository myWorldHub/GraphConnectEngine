using System;
using System.Reflection;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    /// <summary>
    /// classやstructをnewするグラフ
    /// 組み込み型以外につかう
    /// </summary>
    public class CreateInstanceGraph : GenerativeGraph
    {
        public CreateInstanceGraph(NodeConnector connector, MethodInfo methodInfo, bool streamItem = false) : base(connector, methodInfo, streamItem)
        {
            if (!methodInfo.IsConstructor || MethodInfo.DeclaringType == null || methodInfo.IsGenericMethod || methodInfo.IsGenericMethodDefinition)
                return;//TODO エラー
        }

        public override string GetGraphName()
        {
            return "Create Instance Graph";
        }

        protected override bool InvokeMethod(ProcessCallArgs args,out object result,bool goBack)
        {
            if (TryGetParameterValues(args,out var param, goBack))
            {
                result =  Activator.CreateInstance(MethodInfo.DeclaringType, param);
                return true;
            }

            result = null;
            return false;
        }
    }
}