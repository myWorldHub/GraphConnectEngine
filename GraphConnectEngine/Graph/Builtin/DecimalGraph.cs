using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Builtin
{
    public class DecimalGraph : ValueGraph<System.Decimal>
    {
        public DecimalGraph(NodeConnector connector) : base(connector, 0)
        {
        }
    }
}