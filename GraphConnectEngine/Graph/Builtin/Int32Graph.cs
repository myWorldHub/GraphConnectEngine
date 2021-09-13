using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Builtin
{
    public class Int32Graph : ValueGraph<System.Int32>
    {
        public Int32Graph(NodeConnector connector) : base(connector,0){}
    }
}