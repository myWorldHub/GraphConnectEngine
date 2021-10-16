using System.Threading.Tasks;
using GraphConnectEngine.Node;
using GraphConnectEngine.Variable;

namespace GraphConnectEngine.Graphs.Variable
{
    /// <summary>
    /// IVariableHolderの変数を取得するグラフ
    ///
    /// OutItemNode[0]に変数が渡される
    /// </summary>
    public class GetVariableGraph : VariableGraph
    {

        public GetVariableGraph(NodeConnector connector,IVariableHolder holder) : base(connector,holder)
        {
            AddNode(new OutItemNode(this, typeof(void), 0,"Value"));
        }


        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            //Holderがない
            if (Holder == null)
                return Task.FromResult(ProcessCallResult.Fail());

            //取得
            var result = Holder.TryGet(VariableName);
            
            if(!result.IsSucceeded)
                return Task.FromResult(ProcessCallResult.Fail());

            return Task.FromResult(ProcessCallResult.Success(new [] {result.Value}, OutProcessNodes[0]));
        }

        protected override void OnVariableChanged()
        {
            if (Holder == null)
                return;
            
            if (Holder.ContainsKey(VariableName))
            {
                var rs = Holder.TryGetVariableType(VariableName);
                OutItemNodes[0].SetItemType(rs.Value);
            }
        }

        protected override void OnHolderChanged()
        {
            if (Holder == null)
                return;
            
            if (Holder.ContainsKey(VariableName))
            {
                var rs = Holder.TryGetVariableType(VariableName);
                OutItemNodes[0].SetItemType(rs.Value);
            }
        }

        public override string GraphName => "Get Variable Graph";
    }
}