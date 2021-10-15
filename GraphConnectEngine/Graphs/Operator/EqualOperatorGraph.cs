using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// ==を行うグラフ
    /// </summary>
    public class EqualOperatorGraph : MidOperatorGraph
    {
        public EqualOperatorGraph(NodeConnector connector) : base(connector,OperatorChecker.MidOperator.op_Equality)
        {
        }
        
        public override string GetGraphName()=> "Equal Operator Graph";
    }
}