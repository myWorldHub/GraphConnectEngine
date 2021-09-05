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
            string myHash = ParentGraph.GetHashCode().ToString();
            string myName =  $"{ParentGraph.GetGraphName()}[{myHash}]";
            string preset = $"{myName} Called Process > ";

            GraphEngineLogger.Debug($"{myName} Started to Calling Process with\n{args}");

            if (!Connector.TryGetOtherNodes(this, out InProcessNode[] resolvers))
                return;
            
            for (int i = 0; i < resolvers.Length; i++)
            {
                var inProcessNode = resolvers[i];
                if (args.TryAdd(myHash + "_" + i, false, out var nargs))
                {
                    GraphEngineLogger.Debug(preset + $"{inProcessNode.ParentGraph.GetGraphName()}[{inProcessNode.ParentGraph.GetHashCode()}] with\n{nargs}");
                    inProcessNode.OnCalled(nargs);
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