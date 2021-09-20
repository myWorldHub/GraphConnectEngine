using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Operator
{
    public class ModulusOperatorGraph : MidOperatorGraph
    {
        public ModulusOperatorGraph(NodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_Modulus)
        {
        }

        public override string GetGraphName()
        {
            return "Modulus Graph";
        }
    }
}