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

        public bool Get(ProcessCallArgs args,out object result,bool goBack)
        {
            result =  Number;
            return true;
        }

        protected override bool OnProcessCall(ProcessCallArgs args)
        {
            return OutItemNode.TryGetValue(args, out object result,false);
        }

        public override string GetGraphName()
        {
            return "Int Graph";
        }

    }
}