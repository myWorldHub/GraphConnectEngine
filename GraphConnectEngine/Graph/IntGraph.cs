using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class IntGraph : GraphBase
    {
        public int Number = 0;

        public IntGraph(NodeConnector connector) : base(connector)
        {
            AddItemNode(new OutItemNode(this,connector,typeof(int),0));
        }


        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            results = new object[] {Number};
            nextNode = OutProcessNode;
            return true;
        }

        public override string GetGraphName()
        {
            return "Int Graph";
        }

    }
}