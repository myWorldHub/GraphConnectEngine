namespace GraphConnectEngine.Nodes
{
    /// <summary>
    /// Node同士がどのように繋がっているか管理する
    /// </summary>
    public interface INodeConnector : INodeStatusListener
    {

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T[] GetOtherNodes<T>(INode key);

        /// <summary>
        /// 繋がれているノードを取得する
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        INode[] GetOtherNodes(INode key);

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryGetOtherNodes<T>(INode key, out T[] result);

        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryGetOtherNodes(INode key, out INode[] result);

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryGetAnotherNode<T>(INode key, out T result) where T : class;
        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryGetAnotherNode(INode key, out INode result);

        /// <summary>
        /// node1がnode2と繋がっているかチェック(node1のみ)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        bool IsConnected(INode node1, INode node2);

        /// <summary>
        /// ノードとノードを繋ぐ
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        bool ConnectNode(INode node1, INode node2);

        /// <summary>
        /// ノードを切断する
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        bool DisconnectNode(INode node1, INode node2);

        /// <summary>
        /// 指定されたノードの接続情報を消す
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        bool DisconnectAllNode(INode node);
    }
}