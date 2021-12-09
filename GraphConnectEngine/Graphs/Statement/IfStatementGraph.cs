using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

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
        
        public IfStatementGraph(string id) : base(id)
        {
            IItemTypeResolver resolver = new ItemTypeResolver(typeof(bool), "expression");
            
            AddNode(new InItemNode(this,resolver));
            AddNode(new OutItemNode(this, resolver,0));

            AddNode(new OutProcessNode(this));
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessData args, object[] parameters)
        {
            bool result = (bool)parameters[0];
            return Task.FromResult(ProcessCallResult.Success(
                new object[]
                {
                    result
                },
                result ? OutProcessNodes[0] : OutProcessNodes[1]));
        }

        public override string GraphName => "IfStatement";
    }
}
