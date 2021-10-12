using System;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Core
{
    /// <summary>
    ///
    /// </summary>
    public interface INodeStatusListener
    {
        event EventHandler<NodeConnectEventArgs> OnConnect;
        event EventHandler<NodeConnectEventArgs> OnDisconnect;

        void InvokeConnectEvent(NodeConnectEventArgs args);

        void InvokeDisconnectEvent(NodeConnectEventArgs args);
    }

    public class NodeConnectEventArgs : EventArgs
    {
        public Node.Node SenderNode;
        public Node.Node OtherNode;
    }
}