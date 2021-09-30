using System;
using System.Threading.Tasks;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Variable
{
    public class GetVariableGraph : VariableGraph
    {

        public event EventHandler OnVariableFound;

        public event EventHandler OnVariableNotFound;

        public GetVariableGraph(NodeConnector connector,VariableHolder holder) : base(connector,holder)
        {
            AddNode(new OutItemNode(this, typeof(void), 0,"Value"));
        }


        public override async Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            //Holderがない
            if (Holder == null)
                return ProcessCallResult.Fail();

            //取得
            var result = await Holder.TryGet(VariableName);
            
            if(!result.IsSucceeded)
                return ProcessCallResult.Fail();

            return ProcessCallResult.Success(new [] {result.Value}, OutProcessNode);
        }

        protected override async void OnVariableChanged()
        {
            if (Holder == null)
                return;
            
            if (await Holder.ContainsKey(VariableName))
            {
                OutItemNodes[0].SetItemType(await Holder.GetVariableType(VariableName));
                OnVariableFound?.Invoke(this,new EventArgs());
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
                OutItemNodes[0].SetItemType(await Holder.GetVariableType(VariableName));
                OnVariableFound?.Invoke(this, new EventArgs());
            }
            else
            {
                OnVariableNotFound?.Invoke(this, new EventArgs());
            }
        }

        protected override void OnVariableRemoved()
        {
            OnVariableNotFound?.Invoke(this,new EventArgs());
        }

        public override string GetGraphName() => "Get Variable Graph";
    }
}