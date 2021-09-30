using System;
using System.Threading.Tasks;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Variable
{
    public class SetVariableGraph : VariableGraph
    {

        public event EventHandler OnVariableFound;

        public event EventHandler OnVariableNotFound;

        public SetVariableGraph(NodeConnector connector,VariableHolder holder) : base(connector,holder)
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
            if (!await Holder.Update(VariableName, obj))
                return ProcessCallResult.Fail();

            return ProcessCallResult.Success(new[] {obj}, OutProcessNode);
        }

        protected override async void OnVariableChanged()
        {
            if (Holder == null)
                return;

            if (await Holder.ContainsKey(VariableName))
            {
                var type = await Holder.GetVariableType(VariableName);
                InItemNodes[0].SetItemType(type);
                OutItemNodes[0].SetItemType(type);
                
                OnVariableFound?.Invoke(this, new EventArgs());
            }
            else
            {
                OnVariableNotFound?.Invoke(this, new EventArgs());
            }
        }

        protected override async void OnHolderChanged()
        {
            if (Holder == null)
                return;
            
            if (await Holder.ContainsKey(VariableName))
            {
                var type = await Holder.GetVariableType(VariableName);
                InItemNodes[0].SetItemType(type);
                OutItemNodes[0].SetItemType(type);
                
                OnVariableFound?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                OnVariableNotFound?.Invoke(this, EventArgs.Empty);
            }
        }

        protected override void OnVariableRemoved()
        {
            OnVariableNotFound?.Invoke(this, EventArgs.Empty);
        }

        public override string GetGraphName() => "Set Variable Graph";
        
    }
}