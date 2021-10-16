using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// >= を行うグラフ
    /// </summary>
    public class GreaterThanOperatorGraph : MidOperatorGraph
    {
        public GreaterThanOperatorGraph(INodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_GreaterThan)
        {
        }

        public override string GraphName => "Greater Than Graph";
    }
}