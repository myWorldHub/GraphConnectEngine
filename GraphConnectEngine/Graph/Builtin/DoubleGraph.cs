using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Builtin
{
    public class DoubleGraph : ValueGraph<System.Double>
    {
        public DoubleGraph(NodeConnector connector) : base(connector, 0d)
        {
        }
    }
}