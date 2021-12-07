namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// 足し算をするグラフ
    /// </summary>
    public class AdditionOperatorGraph : MidOperatorGraph
    {
        public AdditionOperatorGraph() : base(OperatorChecker.MidOperator.op_Addition)
        {
        }

        public override string GraphName => "AdditionOperator";
    }
}
