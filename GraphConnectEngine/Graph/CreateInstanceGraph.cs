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
            if (!methodInfo.IsConstructor || MethodInfo.DeclaringType == null)
                return;//TODO エラー
        }

        public override string GetGraphName()
        {
            return "Create Instance Graph";
        }

        protected override object InvokeMethod()
        {
            if (TryGetParameterValues(out var param))
            {
                return Activator.CreateInstance(MethodInfo.DeclaringType, param);
            }

            return null;//TODO 失敗
        }
    }
}