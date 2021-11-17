using System.Threading.Tasks;
using GraphConnectEngine.Nodes;
using GraphConnectEngine.Variable;

namespace GraphConnectEngine.Graphs.Variable
{
    /// <summary>
    /// IVariableHolderの変数の値を設定するグラフ
    /// </summary>
    public class SetVariableGraph : VariableGraph
    {

        public SetVariableGraph(INodeConnector connector, IVariableHolder holder) : base(connector,holder)
        {
            IItemTypeResolver resolver = new ItemTypeResolver(typeof(void), "Value");
            AddNode(new InItemNode(this, resolver));
            AddNode(new OutItemNode(this, resolver,0));
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            if (Holder == null)
                return Task.FromResult(ProcessCallResult.Fail());

            var obj = parameters[0];
            
            //更新
            if (!Holder.Update(VariableName, obj))
                return Task.FromResult(ProcessCallResult.Fail());

            return Task.FromResult(ProcessCallResult.Success(new[] {obj}, OutProcessNodes[0]));
        }

        protected override void OnVariableChanged()
        {
            if (Holder == null)
                return;

            if (Holder.ContainsKey(VariableName))
            {
                var rs = Holder.TryGetVariableType(VariableName);
                InItemNodes[0].TypeResolver.SetItemType(rs.Value);
            }
        }

        protected override void OnHolderChanged()
        {
            if (Holder == null)
                return;
            
            if (Holder.ContainsKey(VariableName))
            {
                var rs = Holder.TryGetVariableType(VariableName);
                InItemNodes[0].TypeResolver.SetItemType(rs.Value);
            }
        }

        public override string GraphName => "SetVariable";
        
    }
}