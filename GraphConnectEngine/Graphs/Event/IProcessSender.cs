using System.Threading.Tasks;

namespace GraphConnectEngine.Graphs.Event
{
    /// <summary>
    /// Processを発生させるためのインターフェース
    /// 例えばUpdaterGraphは、どのようにプロセスを開始するかを管理するために利用している
    /// </summary>
    public interface IProcessSender
    {
        Task Fire(IGraph graph,object[] parameters);
    }
}