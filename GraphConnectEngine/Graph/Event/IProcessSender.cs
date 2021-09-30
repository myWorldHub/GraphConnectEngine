using System.Threading.Tasks;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Event
{
    public interface IProcessSender
    {
        Task Fire(OutProcessNode node);
    }
}