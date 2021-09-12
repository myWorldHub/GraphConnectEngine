using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Variable
{
    /// <summary>
    /// TODO リスナをつける
    /// </summary>
    public class SetVariableGraph : VariableGraph
    {

        public SetVariableGraph(NodeConnector connector,VariableHolder holder) : base(connector,holder)
        {
            AddItemNode(new InItemNode(this, typeof(void)));
            AddItemNode(new OutItemNode(this,typeof(void),0));
        }
        
        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
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
            throw new NotImplementedException();
        }

        protected override void OnHolderChanged()
        {
            throw new NotImplementedException();
        }
        
    }
}