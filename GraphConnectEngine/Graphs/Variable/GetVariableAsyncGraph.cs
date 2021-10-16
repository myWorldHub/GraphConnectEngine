using System.Threading.Tasks;
using GraphConnectEngine.Node;
using GraphConnectEngine.Variable;

namespace GraphConnectEngine.Graphs.Variable
{
    /// <summary>
    /// IVariableHolderAsyncの変数を取得するグラフ
    ///
    /// OutItemNode[0]に変数が渡される
    /// </summary>
    public class GetVariableAsyncGraph : VariableAsyncGraph
    {

        public GetVariableAsyncGraph(INodeConnector connector,IVariableHolderAsync holder) : base(connector,holder)
        {
            AddNode(new OutItemNode(this, typeof(void), 0,"Value"));
        }


        public override async Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            //Holderがない
            if (Holder == null)
                return ProcessCallResult.Fail();

            //取得
            var result = await Holder.TryGetAsync(VariableName);
            
            if(!result.IsSucceeded)
                return ProcessCallResult.Fail();

            return ProcessCallResult.Success(new [] {result.Value}, OutProcessNodes[0]);
        }

        protected override async void OnVariableChanged()
        {
            if (Holder == null)
                return;
            
            if (await Holder.ContainsKeyAsync(VariableName))
            {
                var rs = await Holder.TryGetVariableTypeAsync(VariableName);
                OutItemNodes[0].SetItemType(rs.Value);
            }
        }

        protected override async void OnHolderChanged()
        {
            if (Holder == null)
                return;
            
            if (await Holder.ContainsKeyAsync(VariableName))
            {
                var rs = await Holder.TryGetVariableTypeAsync(VariableName);
                OutItemNodes[0].SetItemType(rs.Value);
            }
        }

        public override string GraphName => "Get Variable Graph";
    }
}