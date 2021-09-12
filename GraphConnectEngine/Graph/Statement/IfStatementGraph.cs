using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Statement
{
    public class IfStatementGraph : GraphBase
    {

        public readonly OutProcessNode FalseOutProcessNode;
        
        public IfStatementGraph(NodeConnector connector) : base(connector)
        {
            AddItemNode(new InItemNode(this,connector,typeof(bool)));
            AddItemNode(new OutItemNode(this,connector,typeof(bool),0));

            FalseOutProcessNode = new OutProcessNode(this, connector);
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!GetInItemNode(0).GetItemFromConnectedNode(args, out bool result))
            {
                results = null;
                nextNode = null;
                return false;
            }

            results = new object[] {result};
            nextNode = result ? OutProcessNode : FalseOutProcessNode;
            return true;
        }

        public override string GetGraphName()
        {
            return "If Statement Graph";
        }
    }
}