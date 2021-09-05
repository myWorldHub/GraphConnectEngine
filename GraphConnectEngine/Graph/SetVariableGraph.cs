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


        protected override bool OnProcessCall(ProcessCallArgs args)
        {
            if (InItemNode.Connector.TryGetAnotherNode(InItemNode, out OutItemNode node))
            {
                if (node.TryGetValue<object>(args, out object result,false))
                {
                    if (Holder.UpdateItem(_variableName, result))
                    {
                        OutProcessNode.CallProcess(args);
                        return true;
                    }
                }
            }

            return false;   
        }

        public override string GetGraphName()
        {
            return "Set Variable Graph";
        }
        
    }
}