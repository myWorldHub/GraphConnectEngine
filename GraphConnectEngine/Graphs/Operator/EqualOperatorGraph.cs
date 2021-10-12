using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Operator
{
    public class EqualOperatorGraph : MidOperatorGraph
    {
        public EqualOperatorGraph(NodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_Equality)
        {
        }
        
        public override string GetGraphName()=> "Equal Operator Graph";
    }
}