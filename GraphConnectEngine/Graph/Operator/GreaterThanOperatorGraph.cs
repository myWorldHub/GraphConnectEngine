using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Operator
{
    public class GreaterThanOperatorGraph : MidOperatorGraph
    {
        public GreaterThanOperatorGraph(NodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_GreaterThan)
        {
        }
        
        public override string GetGraphName()
        {
            return "Greater Than Graph";
        }
    }
}