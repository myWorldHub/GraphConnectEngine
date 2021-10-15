using System.Threading.Tasks;

namespace GraphConnectEngine.Graphs.Event
{
    public interface IProcessSender
    {
        Task Fire(Graph graph,object[] parameters);
    }
}