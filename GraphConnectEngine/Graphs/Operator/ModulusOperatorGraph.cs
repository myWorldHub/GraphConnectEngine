using GraphConnectEngine.Nodes;

namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// op_Modulusを行うグラフ
    /// </summary>
    public class ModulusOperatorGraph : MidOperatorGraph
    {
        public ModulusOperatorGraph() : base(OperatorChecker.MidOperator.op_Modulus)
        {
        }

        public override string GraphName => "ModulusOperator";
    }
}
