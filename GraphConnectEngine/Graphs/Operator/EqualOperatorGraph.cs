namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// ==を行うグラフ
    /// </summary>
    public class EqualOperatorGraph : MidOperatorGraph
    {
        public EqualOperatorGraph() : base(OperatorChecker.MidOperator.op_Equality)
        {
        }

        public override string GraphName  => "EqualOperator";
    }
}
