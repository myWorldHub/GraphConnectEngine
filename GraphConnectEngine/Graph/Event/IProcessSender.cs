using System.Threading.Tasks;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Event
{
    public interface IProcessSender
    {
        Task Fire(GraphBase graph,object[] parameters);
    }
}