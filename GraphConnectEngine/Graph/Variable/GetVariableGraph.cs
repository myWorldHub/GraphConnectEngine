using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Variable
{
    public class GetVariableGraph : VariableGraph
    {

        public GetVariableGraph(NodeConnector connector,VariableHolder holder) : base(connector,holder)
        {
            AddItemNode(new OutItemNode(this, typeof(void), 0));
        }


        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
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
            throw new NotImplementedException();
        }

        protected override void OnHolderChanged()
        {
            throw new NotImplementedException();
        }
    }
}