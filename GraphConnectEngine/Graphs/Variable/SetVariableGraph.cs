using System.Threading.Tasks;
using GraphConnectEngine.Node;
using GraphConnectEngine.Variable;

namespace GraphConnectEngine.Graphs.Variable
{
    public class SetVariableGraph : VariableGraph
    {

        public SetVariableGraph(NodeConnector connector, IVariableHolder holder) : base(connector,holder)
        {
            AddNode(new InItemNode(this, typeof(void),"Value"));
            AddNode(new OutItemNode(this,typeof(void),0,"Value"));
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            if (Holder == null)
                return Task.FromResult(ProcessCallResult.Fail());

            var obj = parameters[0];
            
            //更新
            if (!Holder.Update(VariableName, obj))
                return Task.FromResult(ProcessCallResult.Fail());

            return Task.FromResult(ProcessCallResult.Success(new[] {obj}, OutProcessNode));
        }

        protected override void OnVariableChanged()
        {
            if (Holder == null)
                return;

            if (Holder.ContainsKey(VariableName))
            {
                var rs = Holder.TryGetVariableType(VariableName);
                InItemNodes[0].SetItemType(rs.Value);
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
                InItemNodes[0].SetItemType(rs.Value);
                OutItemNodes[0].SetItemType(rs.Value);
            }
        }
        
        public override string GetGraphName() => "Set Variable Graph";
        
    }
}