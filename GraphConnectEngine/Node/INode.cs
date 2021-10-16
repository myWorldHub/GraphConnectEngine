using System;

namespace GraphConnectEngine.Node
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
        Graph Graph { get; set; }
        
        /// <summary>
        /// 引数に指定されたノードの型が接続可能なものか確認する
        ///
        /// 例えば
        /// InItemNodeはOutItemNodeとしかつなげないし、
        /// OutProcessNodeはInProcessNodeとしかつなげない
        /// </summary>
        /// <param name="type">型</param>
        /// <returns></returns>
        bool IsAttachableNodeType(Type type);

        /// <summary>
        /// 指定されたノードと接続できる状態かどうかを確認する
        /// </summary>
        /// <param name="node">ノード</param>
        /// <returns></returns>
        bool CanAttach(Node node);

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