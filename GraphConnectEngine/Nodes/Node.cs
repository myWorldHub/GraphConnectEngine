using System;
using System.Collections.Generic;

namespace GraphConnectEngine.Nodes
{
    /// <summary>
    /// ノード
    ///
    /// ノードはグラフに所属する
    /// InItemNode,OutItemNode,InProcessNode,OutProcessNodeがある
    /// </summary>
    public abstract class Node : INode
    {
        
        public IGraph Graph { get; set; }

        private Dictionary<string, object> _data = new Dictionary<string, object>();

        private bool _isDisposed;

        public event EventHandler<NodeConnectEventArgs> OnConnect;

        public event EventHandler<NodeConnectEventArgs> OnDisconnect;
        
        public abstract bool IsAttachableNodeType(Type type);

        public abstract bool CanAttach(INode node);
        
        public object GetData(string key)
        {
            return _data.ContainsKey(key) ? _data[key] : null;
        }

        public void SetData(string key, object value)
        {
            _data[key] = value;
        }

        public void InvokeConnectEvent(NodeConnectEventArgs args)
        {
            OnConnect?.Invoke(this, args);
        }

        public void InvokeDisconnectEvent(NodeConnectEventArgs args)
        {
            OnDisconnect?.Invoke(this, args);
        }

        ~Node()
        {
            Dispose(false);
        }
        
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isDisposing"></param>
        protected void Dispose(bool isDisposing)
        {
            if (!_isDisposed)
            {
                _isDisposed = true;
                Graph.Connector.DisconnectAllNode(this);
            }
        }
    }
}