using System;

namespace GraphConnectEngine.Core
{
    public class OutProcessNode : GraphParentResolver
    {

        public OutProcessNode(GraphBase parentGraph, NodeConnector connector) : base(parentGraph, connector)
        {
        }

        public void CallProcess(ProcessCallArgs args)
        {

            var a = Connector.GetOtherNodes(this);
            
            if (Connector.TryGetOtherNodes(this, out InProcessNode[] resolvers))
            {
                foreach (var inProcessNode in resolvers)
                {
                    inProcessNode.OnCalled(args);
                }
            }
        }
        
        public override bool IsAttachableGraphType(Type type)
        {
            var dt = typeof(InProcessNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(GraphParentResolver resolver)
        {
            if (resolver is InProcessNode outNode)
            {
                return true;
            }
            return false;
        }
    }
}