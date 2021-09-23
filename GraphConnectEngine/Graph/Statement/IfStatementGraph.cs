using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Statement
{
    public class IfStatementGraph : GraphBase
    {
        
        public IfStatementGraph(NodeConnector connector) : base(connector)
        {
            AddNode(new InItemNode(this,typeof(bool),"expression"));
            AddNode(new OutItemNode(this,typeof(bool),0,"expression"));

            AddNode(new OutProcessNode(this));
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!InItemNodes[0].GetItemFromConnectedNode(args, out bool result))
            {
                results = null;
                nextNode = null;
                return false;
            }

            results = new object[] {result};
            nextNode = result ? OutProcessNode : OutProcessNodes[1];
            return true;
        }

        public override string GetGraphName() => "If Statement Graph";
    }
}