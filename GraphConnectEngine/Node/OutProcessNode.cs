using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Node
{
    public class OutProcessNode : Node
    {

        public OutProcessNode(Graph parentGraph) : base(parentGraph)
        {
        }

        public async Task<bool> CallProcess(ProcessCallArgs args)
        {
            Logger.Debug($"OutProcessNode.CallProcess() Start > {ParentGraph.Id} > {args}");

            if (!Connector.TryGetOtherNodes(this, out InProcessNode[] resolvers))
            {
                Logger.Debug($"OutProcessNode.CallProcess().Success > No node is Connected");
                return true;
            }
            
            for (int i = 0; i < resolvers.Length; i++)
            {
                var inProcessNode = resolvers[i];
                if (args.TryAdd(ParentGraph.Id + "_" + i, true, out var nargs))
                {
                    Logger.Debug($"OutProcessNode.CallProcess().Call InProcessNode {i} / {resolvers.Length}");
                    await inProcessNode.OnCalled(this,nargs);
                }
            }

            return true;
        }
        
        public override bool IsAttachableGraphType(Type type)
        {
            var dt = typeof(InProcessNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(Node resolver)
        {
            if (resolver is InProcessNode outNode)
            {
                return true;
            }
            return false;
        }
    }
}