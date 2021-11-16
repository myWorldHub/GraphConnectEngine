using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphConnectEngine.Nodes
{
    /// <summary>
    /// Node同士がどのように繋がっているか管理する
    /// </summary>
    public interface INodeConnectorAsync : INodeConnector
    {

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T[]> GetOtherNodesAsync<T>(INode key);

        /// <summary>
        /// 繋がれているノードを取得する
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<INode[]> GetOtherNodesAsync(INode key);

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<ValueResult<T[]>> TryGetOtherNodesAsync<T>(INode key);

        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<ValueResult<INode[]>> TryGetOtherNodesAsync(INode key);
        
        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<ValueResult<T>> TryGetAnotherNodeAsync<T>(INode key) where T : class;
        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<ValueResult<INode>> TryGetAnotherNodeAsync(INode key);

        /// <summary>
        /// node1がnode2と繋がっているかチェック(node1のみ)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        Task<bool> IsConnectedAsync(INode node1, INode node2);

        /// <summary>
        /// ノードとノードを繋ぐ
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        Task<bool> ConnectNodeAsync(INode node1, INode node2);

        /// <summary>
        /// ノードを切断する
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        Task<bool> DisconnectNodeAsync(INode node1, INode node2);

        /// <summary>
        /// 指定されたノードの接続情報を消す
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        Task<bool> DisconnectAllNodeAsync(INode node);

        
        /// <summary>
        /// すべての接続されているノードのペアを取得する
        /// </summary>
        /// <returns></returns>
        Task<ISet<(INode,INode)>> GetAllNodePairsAsync();
    }
}