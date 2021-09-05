using System;

namespace GraphConnectEngine.Core
{
    public class InProcessNode : GraphParentResolver
    {

        public delegate bool ProcessCall(ProcessCallArgs args);
        
        public readonly ProcessCall OnCalled;

        public InProcessNode(GraphBase parentGraph, NodeConnector connector, ProcessCall actionOnCall) : base(parentGraph,connector) 
        {
            OnCalled = actionOnCall;
        }

        public override bool IsAttachableGraphType(Type type)
        {
            var dt = typeof(OutProcessNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(GraphParentResolver resolver)
        {
            if (resolver is OutProcessNode outNode)
            {
                return Connector.GetOtherNodes(this).Length == 0;
            }
            return false;
        }
    }
}