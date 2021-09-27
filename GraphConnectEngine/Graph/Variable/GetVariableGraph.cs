using System;
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


        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (Holder == null)
            {
                results = null;
                nextNode = null;
                return false;
            }

            if(!Holder?.ContainsKey(VariableName) ?? true)
            {
                results = null;
                nextNode = null;
                return false;
            }

            results = new[]
            {
                Holder[VariableName]
            };
            nextNode = OutProcessNode;
            return true;
        }

        protected override void OnVariableChanged()
        {
            if (Holder?.ContainsKey(VariableName) ?? false)
            {
                OutItemNodes[0].SetItemType(Holder.GetVariableType(VariableName));
                OnVariableFound?.Invoke(this,new EventArgs());
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
                OutItemNodes[0].SetItemType(Holder.GetVariableType(VariableName));
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