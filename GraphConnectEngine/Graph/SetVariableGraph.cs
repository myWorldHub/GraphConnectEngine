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
        
        public readonly InProcessNode InProcessNode;
        public readonly OutProcessNode OutProcessNode;
        public readonly InItemNode InItemNode;
        //TODO OutItemNode ノードループ対策してから

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

        public SetVariableGraph(NodeConnector connector,VariableHolder holder)
        {
            Holder = holder;
            InItemNode = new InItemNode(this, connector, typeof(void));
            OutProcessNode = new OutProcessNode(this, connector);
            InProcessNode = new InProcessNode(this, connector, OnCall);
        }

        private bool OnCall(ProcessCallArgs args)
        {
            if (InItemNode.Connector.TryGetAnotherNode(InItemNode, out OutItemNode node))
            {
                if (node.TryGetValue<object>(out object result))
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
        
        public override bool IsConnectedInProcessNode()
        {
            return true;
        }
    }
}