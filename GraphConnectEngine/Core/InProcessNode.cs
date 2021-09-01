using System;

namespace GraphConnectEngine.Core
{
    public class InProcessNode : GraphParentResolver
    {
        private Action _action;

        public InProcessNode(GraphBase parentGraph, NodeConnector connector, Action actionOnCall) : base(parentGraph,connector)
        {
            _action = actionOnCall;
        }

        public void OnProcessCall()
        {
            _action();
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