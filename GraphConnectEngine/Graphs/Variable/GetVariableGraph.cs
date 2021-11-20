using System.Threading.Tasks;
using GraphConnectEngine.Nodes;
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

        public GetVariableGraph(INodeConnector connector,IVariableHolder holder) : base(connector,holder)
        {
            IItemTypeResolver resolver = new ItemTypeResolver(typeof(void), "Value");
            AddNode(new OutItemNode(this, resolver,0));
        }


        public override Task<ProcessCallResult> OnProcessCall(ProcessData args, object[] parameters)
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
                OutItemNodes[0].TypeResolver.SetItemType(rs.Value);
            }
        }

        protected override void OnHolderChanged()
        {
            if (Holder == null)
                return;
            
            if (Holder.ContainsKey(VariableName))
            {
                var rs = Holder.TryGetVariableType(VariableName);
                OutItemNodes[0].TypeResolver.SetItemType(rs.Value);
            }
        }

        public override string GraphName => "GetVariable";
    }
}