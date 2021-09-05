using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class IntGraph : GraphBase
    {
        public int Number = 0;

        public readonly OutItemNode OutItemNode;

        public IntGraph(NodeConnector connector) : base(connector)
        {
            OutItemNode = new OutItemNode(this,connector,typeof(int),Get);
        }

        public bool Get(out object result)
        {
            result =  Number;
            return true;
        }

        public override bool OnProcessCall(ProcessCallArgs args)
        {
            throw new System.NotImplementedException();
        }

        public override string GetGraphName()
        {
            return "Int Graph";
        }

    }
}