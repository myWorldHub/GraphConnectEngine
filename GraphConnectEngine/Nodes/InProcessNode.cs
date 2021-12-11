using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Nodes
{
    /// <summary>
    /// OutProcessNodeに呼ばれてプロセスを開始するノード
    ///
    /// OutProcessNodeは一つしか接続できない
    /// TODO イベント発火ノードは複数繋げるようにする
    /// </summary>
    public class InProcessNode : Node
    {
        public InProcessNode(IGraph parentGraph)
        {
            Graph = parentGraph;
        }

        public async Task<InvokeResult> OnCalled(object sender, ProcessData args)
        {
            return await Graph.Invoke(sender, args);
        }

        public override bool CanAttach(INodeConnector connector,INode anotherNode)
        {
            if (anotherNode is OutProcessNode outNode)
            {
                return connector.GetOtherNodes(this).Length == 0;
            }
            return false;
        }
    }
}
