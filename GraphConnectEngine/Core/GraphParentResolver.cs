using System;

namespace GraphConnectEngine.Core
{
    public abstract class GraphParentResolver : INodeStatusListener
    {

        public NodeConnector Connector { get; }

        public readonly GraphBase ParentGraph;
        
        public event EventHandler<NodeConnectEventArgs> OnConnect;
        public event EventHandler<NodeConnectEventArgs> OnDisconnect;

        public GraphParentResolver(GraphBase parentGraph,NodeConnector connector)
        {
            ParentGraph = parentGraph;
            Connector = connector;
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
    }
}