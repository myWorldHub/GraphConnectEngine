using System;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    
    /// <summary>
    /// TODO リスナをつける
    /// </summary>
    public class GetVariableGraph : GraphBase
    {

        public readonly VariableHolder Holder;
        
        public readonly OutItemNode OutItemNode;

        private string _variableName = "";
        public string VariableName
        {
            get => _variableName;
            set
            {
                _variableName = value;
                if (Holder.TryGetItemType(_variableName, out Type type))
                {
                    OutItemNode.SetItemType(type);
                }
                else
                {
                    OutItemNode.SetItemType(typeof(void));
                }
            }
        }

        public int Depth = -1;

        public GetVariableGraph(NodeConnector connector,VariableHolder holder)
        {
            Holder = holder;
            OutItemNode = new OutItemNode(this, connector, typeof(void), () =>
            {
                if (Holder.TryGetItem(VariableName, out var obj))
                {
                    return obj;
                }
                return null;
            });
        }
        
        public override string GetGraphName()
        {
            return "Get Variable Graph";
        }
    }
}