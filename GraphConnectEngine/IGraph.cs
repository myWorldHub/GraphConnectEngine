using System;
using System.Collections.Generic;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine
{
    /// <summary>
    /// グラフのインターフェース
    /// </summary>
    public interface IGraph : IProcessCall, IDisposable
    {
        /// <summary>
        /// グラフを識別するための一意なID
        /// ProcessCallArgsで利用される
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// グラフ名を取得する
        /// </summary>
        /// <returns></returns>
        string GraphName { get; }
        
        /// <summary>
        /// ノードのコネクター
        /// </summary>
        INodeConnector Connector { get; }

        /// <summary>
        /// InProcessNodeのリスト
        /// </summary>
        IList<InProcessNode> InProcessNodes { get; }

        /// <summary>
        /// OutProcessNodeのリスト
        /// </summary>
        IList<OutProcessNode> OutProcessNodes { get; }

        /// <summary>
        /// InItemNodeのリスト
        /// </summary>
        IList<InItemNode> InItemNodes { get; }

        /// <summary>
        /// OutItemNodeのリスト
        /// </summary>
        IList<OutItemNode> OutItemNodes { get; }

        /// <summary>
        /// 実行ステータスのリスナ
        /// </summary>
        public event EventHandler<GraphStatusEventArgs> OnStatusChanged;
    }

    /// <summary>
    /// グラフの状態に関わるイベント用
    /// </summary>
    public class GraphStatusEventArgs : EventArgs
    {
        public enum EventType
        {
            InvokeCalled,
            ParamError,
            ProcessStart,
            ProcessSuccess,
            ProcessFail,
            CacheUsed,
            CacheError,
            LoopDetected,
            UnknownError
        }

        public EventType Type;
        public ProcessCallArgs Args;
    }
}