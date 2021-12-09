namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// ==を行うグラフ
    /// </summary>
    public class EqualOperatorGraph : MidOperatorGraph
    {
        public EqualOperatorGraph(string id) : base(id,OperatorChecker.MidOperator.op_Equality)
        {
        }

        public override string GraphName  => "EqualOperator";
    }
}
