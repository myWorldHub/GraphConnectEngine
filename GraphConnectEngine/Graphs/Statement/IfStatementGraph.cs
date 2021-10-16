using System.Threading.Tasks;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Statement
{
    /// <summary>
    /// ブール型の変数によってプロセスの分岐を行うグラフ
    ///
    /// OutProcessNodeが2つある
    /// OutProcessNodes[0]はTrueのとき
    /// OutProcessNodes[1]はFalseのとき呼ばれる
    /// </summary>
    public class IfStatementGraph : Graph
    {
        
        public IfStatementGraph(INodeConnector connector) : base(connector)
        {
            AddNode(new InItemNode(this,typeof(bool),"expression"));
            AddNode(new OutItemNode(this,typeof(bool),0,"expression"));

            AddNode(new OutProcessNode(this));
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            bool result = (bool)parameters[0];
            return Task.FromResult(ProcessCallResult.Success(
                new object[]
                {
                    result
                },
                result ? OutProcessNodes[0] : OutProcessNodes[1]));
        }

        public override string GraphName => "If Statement Graph";
    }
}