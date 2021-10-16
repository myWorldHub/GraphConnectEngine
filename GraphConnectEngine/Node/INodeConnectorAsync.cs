using System.Threading.Tasks;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// Node同士がどのように繋がっているか管理する
    /// </summary>
    public interface INodeConnectorAsync : INodeStatusListener
    {

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T[]> GetOtherNodesAsync<T>(Node key);

        /// <summary>
        /// 繋がれているノードを取得する
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<Node[]> GetOtherNodesAsync(Node key);

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<bool> TryGetOtherNodesAsync<T>(Node key, out T[] result);

        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        Task<bool> TryGetOtherNodesAsync(Node key, out Node[] result);
        
        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<bool> TryGetAnotherNodeAsync<T>(Node key, out T result) where T : Node;
        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        Task<bool> TryGetAnotherNodeAsync(Node key, out Node result);

        /// <summary>
        /// node1がnode2と繋がっているかチェック(node1のみ)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        Task<bool> IsConnectedAsync(Node node1, Node node2);

        /// <summary>
        /// ノードとノードを繋ぐ
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        Task<bool> ConnectNodeAsync(Node node1, Node node2);

        /// <summary>
        /// ノードを切断する
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        Task<bool> DisconnectNodeAsync(Node node1, Node node2);

        /// <summary>
        /// 指定されたノードの接続情報を消す
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        Task<bool> DisconnectAllNodeAsync(Node node);
    }
}