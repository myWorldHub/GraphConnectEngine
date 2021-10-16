using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// 足し算をするグラフ
    /// </summary>
    public class AdditionOperatorGraph : MidOperatorGraph
    {
        public AdditionOperatorGraph(INodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_Addition)
        {
        }

        public override string GraphName => "Addition Operator Graph";
    }
}