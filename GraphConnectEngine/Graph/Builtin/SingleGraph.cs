using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Builtin
{
    public class SingleGraph : ValueGraph<System.Single>
    {
        public SingleGraph(NodeConnector connector) : base(connector, 0f)
        {
        }
    }
}