using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Operator
{
    public class AdditionOperatorGraph : MidOperatorGraph
    {
        public AdditionOperatorGraph(NodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_Addition)
        {
        }

        public override string GetGraphName()
        {
            return "Addition Operator Graph";
        }
    }
}