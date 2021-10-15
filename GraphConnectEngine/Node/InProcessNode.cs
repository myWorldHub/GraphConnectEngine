using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Node
{
    public class InProcessNode : Node
    {


        public InProcessNode(Graph parentGraph) : base(parentGraph) 
        {
        }

        public async Task<InvokeResult> OnCalled(object sender, ProcessCallArgs args)
        {
            return await ParentGraph.Invoke(sender, args);
        }

        public override bool IsAttachableGraphType(Type type)
        {
            var dt = typeof(OutProcessNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(Node resolver)
        {
            if (resolver is OutProcessNode outNode)
            {
                return Connector.GetOtherNodes(this).Length == 0;
            }
            return false;
        }
    }
}