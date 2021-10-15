using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// >= を行うグラフ
    /// </summary>
    public class GreaterThanOperatorGraph : MidOperatorGraph
    {
        public GreaterThanOperatorGraph(NodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_GreaterThan)
        {
        }
        
        public override string GetGraphName() => "Greater Than Graph";
    }
}