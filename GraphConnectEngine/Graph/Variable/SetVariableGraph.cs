using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;
using System.Threading.Tasks;

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
            
            if (Holder.Update(VariableName, obj))
            {
                results = new object[]
                {
                    obj
                };
                nextNode = OutProcessNode;
                return true;
            }
            results = null;
            nextNode = null;
            return false;   
        }

        protected override void OnVariableChanged()
        {
            if (Holder?.ContainsKey(VariableName) ?? false)
            {
                var type = Holder.GetVariableType(VariableName);
                InItemNodes[0].SetItemType(type);
                OutItemNodes[0].SetItemType(type);
                
                OnVariableFound?.Invoke(this, new EventArgs());
            }
            else
            {
                OnVariableNotFound?.Invoke(this, new EventArgs());
            }
        }

        protected override void OnHolderChanged()
        {
            if (Holder?.ContainsKey(VariableName) ?? false)
            {
                var type = Holder.GetVariableType(VariableName);
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