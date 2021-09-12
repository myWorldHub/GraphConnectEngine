using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Variable
{
    
    /// <summary>
    /// TODO リスナをつける
    /// </summary>
    public class GetVariableGraph : GraphBase
    {

        public readonly VariableHolder Holder;

        private string _variableName = "";
        public string VariableName
        {
            get => _variableName;
            set
            {
                _variableName = value;
                var node = GetOutItemNode(0);
                if (Holder.TryGetItemType(_variableName, out Type type))
                {
                    node.SetItemType(type);
                }
                else
                {
                    node.SetItemType(typeof(void));
                }
            }
        }

        public int Depth = -1;

        public GetVariableGraph(NodeConnector connector,VariableHolder holder) : base(connector)
        {
            Holder = holder;
            AddItemNode(new OutItemNode(this, typeof(void), 0));
        }


        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if(!Holder.TryGetItem(VariableName, out var obj, Depth))
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
    }
}