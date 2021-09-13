using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Builtin
{
    public class StringGraph : ValueGraph<System.String>
    {
        public StringGraph(NodeConnector connector) : base(connector, "")
        {
        }
    }
}