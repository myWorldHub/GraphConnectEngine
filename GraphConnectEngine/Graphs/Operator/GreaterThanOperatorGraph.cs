namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// >= を行うグラフ
    /// </summary>
    public class GreaterThanOperatorGraph : MidOperatorGraph
    {
        public GreaterThanOperatorGraph() : base(OperatorChecker.MidOperator.op_GreaterThan)
        {
        }

        public override string GraphName => "GreaterThan";
    }
}
