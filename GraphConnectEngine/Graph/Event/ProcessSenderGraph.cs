using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Event
{
    public abstract class ProcessSenderGraph : GraphBase
    {
        
        public ProcessSenderGraph(NodeConnector connector) : base(connector)
        {
        }

        protected virtual void Fire()
        {
            OutProcessNode.CallProcess(ProcessCallArgs.Fire(GetHashCode()));
        }

        public override bool IsConnectedInProcessNode()
        {
            return false;
        }
    }
}