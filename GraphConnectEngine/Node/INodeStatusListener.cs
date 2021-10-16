using System;

namespace GraphConnectEngine.Node
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
        public readonly GraphConnectEngine.Node.Node SenderNode;
        public readonly GraphConnectEngine.Node.Node OtherNode;

        public NodeConnectEventArgs(GraphConnectEngine.Node.Node node1, GraphConnectEngine.Node.Node node2)
        {
            SenderNode = node1;
            OtherNode = node2;
        }
    }
}