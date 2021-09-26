using System;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Node
{
    public class InProcessNode : NodeBase
    {


        public InProcessNode(GraphBase parentGraph) : base(parentGraph) 
        {
        }

        public void OnCalled(object sender, ProcessCallArgs args)
        {
            ParentGraph.Invoke(sender, args, out var results);
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