using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// op_Modulusを行うグラフ
    /// </summary>
    public class ModulusOperatorGraph : MidOperatorGraph
    {
        public ModulusOperatorGraph(NodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_Modulus)
        {
        }

        public override string GetGraphName() => "Modulus Operator Graph";
    }
}