using System;
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
            AddItemNode(new InItemNode(this, typeof(void)));
            AddItemNode(new OutItemNode(this,typeof(void),0));
        }
        
        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (Holder == null)
            {
                results = null;
                nextNode = null;
                return false;
            }
            
            if (GetInItemNode(0).GetItemFromConnectedNode(args, out object result))
            {
                if (Holder.UpdateItem(VariableName, result))
                {
                    results = new object[]
                    {
                        result
                    };
                    nextNode = OutProcessNode;
                    return true;
                }
            }

            results = null;
            nextNode = null;
            return false;   
        }

        public override string GetGraphName()
        {
            return "Set Variable Graph";
        }

        protected override void OnVariableChanged()
        {
            if (Holder?.HasItem(VariableName) ?? false)
            {
                var type = Holder.GetItemType(VariableName);
                GetInItemNode(0).SetItemType(type);
                GetOutItemNode(0).SetItemType(type);
                
                OnVariableFound?.Invoke(this, new EventArgs());
            }
            else
            {
                GetInItemNode(0).SetItemType(typeof(void));
                GetOutItemNode(0).SetItemType(typeof(void));
                
                OnVariableNotFound?.Invoke(this, new EventArgs());
            }
        }

        protected override void OnHolderChanged()
        {
            if (Holder?.HasItem(VariableName) ?? false)
            {
                var type = Holder.GetItemType(VariableName);
                GetInItemNode(0).SetItemType(type);
                GetOutItemNode(0).SetItemType(type);
                
                OnVariableFound?.Invoke(this, new EventArgs());
            }
            else
            {
                GetInItemNode(0).SetItemType(typeof(void));
                GetOutItemNode(0).SetItemType(typeof(void));
                
                OnVariableNotFound?.Invoke(this, new EventArgs());
            }
        }

        protected override void OnVariableRemoved()
        {
            OnVariableNotFound?.Invoke(this, new EventArgs());
        }
        
    }
}