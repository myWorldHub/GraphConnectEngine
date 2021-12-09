using System.Threading.Tasks;
using GraphConnectEngine.Nodes;
using GraphConnectEngine.Variable;

namespace GraphConnectEngine.Graphs.Variable
{
    /// <summary>
    /// IVariableHolderAsyncの変数の値を設定するグラフ
    /// </summary>
    public class SetVariableAsyncGraph : VariableAsyncGraph
    {

        public SetVariableAsyncGraph(string id, IVariableHolderAsync holder) : base(id,holder)
        {
            IItemTypeResolver resolver = new ItemTypeResolver(typeof(void), "Value");
            AddNode(new InItemNode(this, resolver));
            AddNode(new OutItemNode(this, resolver,0));
        }

        public override async Task<ProcessCallResult> OnProcessCall(ProcessData args, object[] parameters)
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
                InItemNodes[0].TypeResolver.SetItemType(rs.Value);
            }
        }

        protected override async void OnHolderChanged()
        {
            if (Holder == null)
                return;
            
            if (await Holder.ContainsKeyAsync(VariableName))
            {
                var rs = await Holder.TryGetVariableTypeAsync(VariableName);
                InItemNodes[0].TypeResolver.SetItemType(rs.Value);
            }
        }

        public override string GraphName => "SetVariableAsync";
        
    }
}
