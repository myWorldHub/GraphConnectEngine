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
            AddItemNode(new OutItemNode(this, typeof(void), 0));
        }


        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (Holder == null)
            {
                results = null;
                nextNode = null;
                return false;
            }

            if(!Holder.TryGetItem(VariableName, out var obj, -1))
            {
                results = null;
                nextNode = null;
                return false;
            }

            results = new[] {obj};
            nextNode = OutProcessNode;
            return true;
        }

        public override string GetGraphName()
        {
            return "Get Variable Graph";
        }

        protected override void OnVariableChanged()
        {
            if (Holder?.HasItem(VariableName) ?? false)
            {
                GetOutItemNode(0).SetItemType(Holder.GetItemType(VariableName));
                OnVariableFound?.Invoke(this,new EventArgs());
            }
            else
            {
                GetOutItemNode(0).SetItemType(typeof(void));
                OnVariableNotFound?.Invoke(this, new EventArgs());
            }
        }

        protected override void OnHolderChanged()
        {
            if (Holder?.HasItem(VariableName) ?? false)
            {
                GetOutItemNode(0).SetItemType(Holder.GetItemType(VariableName));
                OnVariableFound?.Invoke(this, new EventArgs());
            }
            else
            {
                GetOutItemNode(0).SetItemType(typeof(void));
                OnVariableNotFound?.Invoke(this, new EventArgs());
            }
        }

        protected override void OnVariableRemoved()
        {
            OnVariableNotFound?.Invoke(this,new EventArgs());
        }
    }
}