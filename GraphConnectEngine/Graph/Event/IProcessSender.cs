using Cysharp.Threading.Tasks;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Event
{
    public interface IProcessSender
    {
        UniTask Fire(OutProcessNode node);
    }
}