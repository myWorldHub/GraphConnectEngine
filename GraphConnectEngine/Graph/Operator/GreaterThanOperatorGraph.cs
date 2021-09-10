using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Operator
{
    public class GreaterThanOperatorGraph : GraphBase
    {
        public GreaterThanOperatorGraph(NodeConnector connector) : base(connector)
        {
            AddItemNode(new InItemNode(this, connector, typeof(int)));
            AddItemNode(new InItemNode(this, connector, typeof(int)));
            
            AddItemNode(new OutItemNode(this, connector, typeof(bool), 0));
            AddItemNode(new OutItemNode(this, connector, typeof(int), 1));
            AddItemNode(new OutItemNode(this, connector, typeof(int), 2));
        }

        protected override bool OnProcessCall(ProcessCallArgs args, object[] param, out object[] results,
            out OutProcessNode nextNode)
        {
            int a = (int) param[0];
            int b = (int) param[1];

            results = new object[]
            {
                a > b,
                a,
                b
            };
            nextNode = OutProcessNode;
            return true;
        }

        public override string GetGraphName()
        {
            return "Greater Than Graph";
        }
    }
}