using System;
using System.Reflection;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Generative
{
    /// <summary>
    /// classやstructをnewするグラフ
    /// 組み込み型以外につかう
    /// </summary>
    public class CreateInstanceGraph : GenerativeGraph
    {
        public CreateInstanceGraph(NodeConnector connector, MethodInfo methodInfo) : base(connector, methodInfo)
        {
            if (!methodInfo.IsConstructor || MethodInfo.DeclaringType == null || methodInfo.IsGenericMethod || methodInfo.IsGenericMethodDefinition)
                return;//TODO エラー
        }

        protected override bool InvokeMethod(ProcessCallArgs args,object[] param,out object result)
        {
            result = Activator.CreateInstance(MethodInfo.DeclaringType, param);
            return true;
        }

        public override string GetGraphName() => "Create Instance Graph";
    }
}