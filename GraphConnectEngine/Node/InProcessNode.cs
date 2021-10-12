using System;
using System.Threading.Tasks;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Node
{
    public class InProcessNode : NodeBase
    {


        public InProcessNode(Core.Graph parentGraph) : base(parentGraph) 
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

        public override bool CanAttach(NodeBase resolver)
        {
            if (resolver is OutProcessNode outNode)
            {
                return Connector.GetOtherNodes(this).Length == 0;
            }
            return false;
        }
    }
}