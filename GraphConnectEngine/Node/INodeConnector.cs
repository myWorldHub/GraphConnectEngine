namespace GraphConnectEngine.Node
{
    /// <summary>
    /// Node同士がどのように繋がっているか管理する
    ///
    /// </summary>
    interface INodeConnector : INodeStatusListener
    {

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T[] GetOtherNodes<T>(Node key);

        /// <summary>
        /// 繋がれているノードを取得する
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Node[] GetOtherNodes(Node key);

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryGetOtherNodes<T>(Node key, out T[] result);

        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryGetOtherNodes(Node key, out Node[] result);
        
        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryGetAnotherNode<T>(Node key, out T result) where T : Node;
        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryGetAnotherNode(Node key, out Node result);

        /// <summary>
        /// node1がnode2と繋がっているかチェック(node1のみ)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        bool IsConnected(Node node1, Node node2);

        /// <summary>
        /// ノードとノードを繋ぐ
        /// 
        /// メモ : 接続する時に呼ぶ順
        /// ConnectNode
        /// IsAttachableGraphType
        /// CanAttach
        /// Register
        /// OnConnect
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        bool ConnectNode(Node node1, Node node2);

        /// <summary>
        /// ノードを切断する
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        bool DisconnectNode(Node node1, Node node2);

        /// <summary>
        /// 指定されたノードの接続情報を消す
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        bool DisconnectAllNode(Node node);
    }
}