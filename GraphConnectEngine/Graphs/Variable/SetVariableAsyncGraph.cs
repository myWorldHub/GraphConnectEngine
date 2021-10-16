using System.Threading.Tasks;
using GraphConnectEngine.Node;
using GraphConnectEngine.Variable;

namespace GraphConnectEngine.Graphs.Variable
{
    /// <summary>
    /// IVariableHolderAsyncの変数の値を設定するグラフ
    /// </summary>
    public class SetVariableAsyncGraph : VariableAsyncGraph
    {

        public SetVariableAsyncGraph(NodeConnector connector, IVariableHolderAsync holder) : base(connector,holder)
        {
            AddNode(new InItemNode(this, typeof(void),"Value"));
            AddNode(new OutItemNode(this,typeof(void),0,"Value"));
        }

        public override async Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            if (Holder == null)
                return ProcessCallResult.Fail();

            var obj = parameters[0];
            
            //更新
            if (!await Holder.UpdateAsync(VariableName, obj))
                return ProcessCallResult.Fail();

            return ProcessCallResult.Success(new[] {obj}, OutProcessNodes[0]);
        }

        protected override async void OnVariableChanged()
        {
            if (Holder == null)
                return;

            if (await Holder.ContainsKeyAsync(VariableName))
            {
                var rs = await Holder.TryGetVariableTypeAsync(VariableName);
                InItemNodes[0].SetItemType(rs.Value);
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
                InItemNodes[0].SetItemType(rs.Value);
                OutItemNodes[0].SetItemType(rs.Value);
            }
        }
        
        public override string GetGraphName() => "Set Variable Graph";
        
    }
}