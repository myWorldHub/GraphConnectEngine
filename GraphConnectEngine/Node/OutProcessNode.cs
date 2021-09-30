using System;
using Cysharp.Threading.Tasks;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Node
{
    public class OutProcessNode : NodeBase
    {

        public OutProcessNode(GraphBase parentGraph) : base(parentGraph)
        {
        }

        public async UniTask<bool> CallProcess(ProcessCallArgs args)
        {
            string myHash = ParentGraph.GetHashCode().ToString();
            string myName =  $"{ParentGraph.GetGraphName()}[{myHash}]";
            string preset = $"{myName} Calls Process > ";

            Logger.Debug($"{myName} Started to Calling Process with\n{args}");

            if (!Connector.TryGetOtherNodes(this, out InProcessNode[] resolvers))
                return true;
            
            for (int i = 0; i < resolvers.Length; i++)
            {
                var inProcessNode = resolvers[i];
                if (args.TryAdd(myHash + "_" + i, true, out var nargs))
                {
                    Logger.Debug(preset + $"{inProcessNode.ParentGraph.GetGraphName()}[{inProcessNode.ParentGraph.GetHashCode()}] with\n{nargs}");
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

        public override bool CanAttach(NodeBase resolver)
        {
            if (resolver is InProcessNode outNode)
            {
                return true;
            }
            return false;
        }
    }
}