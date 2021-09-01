using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class IntGraph : GraphBase
    {
        private int _number = 0;

        public readonly OutItemNode OutItemNode;

        public IntGraph(NodeConnector connector)
        {
            OutItemNode = new OutItemNode(this,connector,typeof(int),()=>Get());
        }

        public void Increment()
        {
            _number++;
        }

        public void Decrement()
        {
            _number--;
        }

        public int Get()
        {
            return _number;
        }

        public override string GetGraphName()
        {
            return "Int Graph";
        }
    }
}