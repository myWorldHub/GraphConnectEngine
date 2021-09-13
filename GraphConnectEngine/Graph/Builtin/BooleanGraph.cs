using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Builtin
{
    public class BooleanGraph : ValueGraph<System.Boolean>
    {
        public BooleanGraph(NodeConnector connector) : base(connector, true)
        {
        }
    }
}