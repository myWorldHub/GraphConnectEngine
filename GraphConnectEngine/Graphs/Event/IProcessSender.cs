using System.Threading.Tasks;

namespace GraphConnectEngine.Graphs.Event
{
    public interface IProcessSender
    {
        Task Fire(Core.Graph graph,object[] parameters);
    }
}