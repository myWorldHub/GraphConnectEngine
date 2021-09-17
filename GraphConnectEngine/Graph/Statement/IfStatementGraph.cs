using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Statement
{
    public class IfStatementGraph : GraphBase
    {
        
        public IfStatementGraph(NodeConnector connector) : base(connector)
        {
            AddNode(new InItemNode(this,typeof(bool)));
            AddNode(new OutItemNode(this,typeof(bool),0));

            AddNode(new OutProcessNode(this));
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
            nextNode = result ? OutProcessNode : GetOutProcessNode(1);
            return true;
        }

        public override string GetGraphName()
        {
            return "If Statement Graph";
        }
    }
}