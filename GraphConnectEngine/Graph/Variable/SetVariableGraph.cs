using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Variable
{
    /// <summary>
    /// TODO リスナをつける
    /// </summary>
    public class SetVariableGraph : GraphBase
    {

        public readonly VariableHolder Holder;

        private string _variableName = "";
        public string VariableName
        {
            get => _variableName;
            set
            {
                _variableName = value;
                if (Holder.TryGetItemType(_variableName, out Type type))
                {
                    GetInItemNode(0).SetItemType(type);
                    GetOutItemNode(0).SetItemType(type);
                }
                else
                {
                    GetInItemNode(0).SetItemType(typeof(void));
                    GetOutItemNode(0).SetItemType(typeof(void));
                }
            }
        }

        public SetVariableGraph(NodeConnector connector,VariableHolder holder) : base(connector)
        {
            Holder = holder;
            AddItemNode(new InItemNode(this, connector, typeof(void)));
            AddItemNode(new OutItemNode(this,connector,typeof(void),0));
        }

        protected override bool OnProcessCall(ProcessCallArgs args, object[] param, out object[] results,
            out OutProcessNode nextNode)
        {
            var result = param[0];
            
            if (Holder.UpdateItem(_variableName, result))
            {
                results = new object[]
                {
                    result
                };
                nextNode = OutProcessNode;
                return true;
            }

            results = null;
            nextNode = null;
            return false;   
        }

        public override string GetGraphName()
        {
            return "Set Variable Graph";
        }
        
    }
}