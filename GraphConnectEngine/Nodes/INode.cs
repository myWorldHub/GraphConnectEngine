using System;

namespace GraphConnectEngine.Nodes
{
    /// <summary>
    /// ノードのインターフェース
    ///
    /// 実装する時はGraphを初期化する
    /// </summary>
    public interface INode : INodeStatusListener,IDisposable
    {

        /// <summary>
        /// グラフ
        /// </summary>
        IGraph Graph { get; set; }

        /// <summary>
        /// 指定されたノードと接続できる状態かどうかを確認する
        /// </summary>
        /// <param name="anotherNode">ノード</param>
        /// <returns></returns>
        bool CanAttach(INodeConnector connector,INode anotherNode);

        /// <summary>
        /// データを取得する
        ///
        /// データは同期しない
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object GetData(string key);

        /// <summary>
        /// データを設定する
        /// 
        /// データは同期しない
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void SetData(string key, object value);
    }
}
