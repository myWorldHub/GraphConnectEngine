using System;

namespace GraphConnectEngine
{
    /// <summary>
    /// ノードの状態のリスナーのインターフェース
    /// </summary>
    public interface INodeStatusListener
    {
        /// <summary>
        /// コネクターによってこのノードが接続されたら呼ばれるイベント
        /// </summary>
        event EventHandler<NodeConnectEventArgs> OnConnect;

        /// <summary>
        /// コネクターによってこのノードが切断されたら呼ばれるイベント
        /// </summary>
        event EventHandler<NodeConnectEventArgs> OnDisconnect;


        /// <summary>
        /// イベント実行用
        /// </summary>
        /// <param name="args"></param>
        void InvokeConnectEvent(NodeConnectEventArgs args);


        /// <summary>
        /// イベント実行用
        /// </summary>
        /// <param name="args"></param>
        void InvokeDisconnectEvent(NodeConnectEventArgs args);
    }

    public class NodeConnectEventArgs : EventArgs
    {
        public Node.Node SenderNode;
        public Node.Node OtherNode;
    }
}