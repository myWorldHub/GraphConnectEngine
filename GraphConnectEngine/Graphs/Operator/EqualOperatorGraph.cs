using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// ==を行うグラフ
    /// </summary>
    public class EqualOperatorGraph : MidOperatorGraph
    {
        public EqualOperatorGraph(INodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_Equality)
        {
        }

        public override string GraphName  => "Equal Operator Graph";
    }
}