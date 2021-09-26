using System;
using System.Collections.Generic;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Node
{
    public abstract class NodeBase : INodeStatusListener,IDisposable
    {

        public NodeConnector Connector
        {
            get
            {
                return ParentGraph.Connector;
            }
        }

        public readonly GraphBase ParentGraph;
        
        public event EventHandler<NodeConnectEventArgs> OnConnect;
        public event EventHandler<NodeConnectEventArgs> OnDisconnect;
        public event EventHandler<EventArgs> OnDispose;

        private bool _isDisposed = false;

        /// <summary>
        /// なんでも良いデータ
        /// </summary>
        public readonly Dictionary<string, object> Args = new Dictionary<string, object>();

        public NodeBase(GraphBase parentGraph)
        {
            ParentGraph = parentGraph;
        }
        
        public void InvokeConnectEvent(NodeConnectEventArgs args)
        {
            OnConnect?.Invoke(this, args);
        }

        public void InvokeDisconnectEvent(NodeConnectEventArgs args)
        {
            OnDisconnect?.Invoke(this,args);
        }

        /// <summary>
        /// アタッチ可能なResolverの型を指定する
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public abstract bool IsAttachableGraphType(Type type);

        /// <summary>
        /// resolverと接続できるかを判断する
        /// 既に接続されているかのチェックは必要ない
        /// </summary>
        /// <param name="resolver"></param>
        /// <returns></returns>
        public abstract bool CanAttach(NodeBase resolver);

        ~NodeBase()
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
                Connector.DisconnectAllNode(this);

                OnDispose?.Invoke(this,new EventArgs());
            }
        }
    }
}