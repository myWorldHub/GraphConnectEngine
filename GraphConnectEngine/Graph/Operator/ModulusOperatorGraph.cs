using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Operator
{
    public class ModulusOperatorGraph : GraphBase
    {
        public ModulusOperatorGraph(NodeConnector connector) : base(connector)
        {
            AddNode(new InItemNode(this, typeof(int)));
            AddNode(new InItemNode(this, typeof(int)));

            AddNode(new OutItemNode(this, typeof(int), 0));
            AddNode(new OutItemNode(this, typeof(int), 1));
            AddNode(new OutItemNode(this, typeof(int), 2));
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!GetInItemNode(0).GetItemFromConnectedNode(args, out int a))
            {
                results = null;
                nextNode = null;
                return false;
            }

            if (!GetInItemNode(1).GetItemFromConnectedNode(args, out int b))
            {
                results = null;
                nextNode = null;
                return false;
            }

            results = new object[]
            {
                a % b,
                a,
                b
            };
            nextNode = OutProcessNode;
            return true;
        }

        public override string GetGraphName()
        {
            return "Modulus Graph";
        }
    }
}