using System;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    /// <summary>
    /// TODO リスナをつける
    /// </summary>
    public class SetVariableGraph : GraphBase
    {

        public readonly VariableHolder Holder;
        
        public readonly InItemNode InItemNode;

        private string _variableName = "";
        public string VariableName
        {
            get => _variableName;
            set
            {
                _variableName = value;
                if (Holder.TryGetItemType(_variableName, out Type type))
                {
                    InItemNode.SetItemType(type);
                }
                else
                {
                    InItemNode.SetItemType(typeof(void));
                }
            }
        }

        public SetVariableGraph(NodeConnector connector,VariableHolder holder) : base(connector)
        {
            Holder = holder;
            InItemNode = new InItemNode(this, connector, typeof(void));
        }


        protected override bool OnProcessCall(ProcessCallArgs args, out OutProcessNode nextNode)
        {
            if (InItemNode.GetItemFromConnectedNode(args, out object result))
            {
                if (Holder.UpdateItem(_variableName, result))
                {
                    nextNode = OutProcessNode;
                    return true;
                }
            }

            nextNode = null;
            return false;   
        }

        public override string GetGraphName()
        {
            return "Set Variable Graph";
        }
        
    }
}