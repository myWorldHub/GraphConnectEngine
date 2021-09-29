using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Event
{
    public interface IProcessSender
    { 
        void Fire(OutProcessNode node);
    }
}