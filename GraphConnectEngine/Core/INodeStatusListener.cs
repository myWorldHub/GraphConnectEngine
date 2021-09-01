using System;

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
        public GraphParentResolver OtherNode;
    }
}