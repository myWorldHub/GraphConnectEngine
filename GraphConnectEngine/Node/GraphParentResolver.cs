using System;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Node
{
    public abstract class GraphParentResolver : INodeStatusListener,IDisposable
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

        private bool _isDisposed = false;

        public GraphParentResolver(GraphBase parentGraph)
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
        public abstract bool CanAttach(GraphParentResolver resolver);

        ~GraphParentResolver()
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
        protected virtual void Dispose(bool isDisposing)
        {
            if (_isDisposed)
            {
                Connector.DisconnectAllNode(this);
                _isDisposed = true;
            }
        }
    }
}