using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// OutProcessNodeに呼ばれてプロセスを開始するノード
    ///
    /// OutProcessNodeは一つしか接続できない
    /// TODO イベント発火ノードは複数繋げるようにする
    /// </summary>
    public class InProcessNode : Node
    {
        public InProcessNode(Graph parentGraph)
        {
            Graph = parentGraph;
        }

        public async Task<InvokeResult> OnCalled(object sender, ProcessCallArgs args)
        {
            return await Graph.Invoke(sender, args);
        }

        public override bool IsAttachableNodeType(Type type)
        {
            var dt = typeof(OutProcessNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(Node resolver)
        {
            if (resolver is OutProcessNode outNode)
            {
                return Graph.Connector.GetOtherNodes(this).Length == 0;
            }
            return false;
        }
    }
}