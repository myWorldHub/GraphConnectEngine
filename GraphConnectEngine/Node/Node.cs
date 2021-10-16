using System;
using System.Collections.Generic;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// ノード
    ///
    /// ノードはグラフに所属する
    /// InItemNode,OutItemNode,InProcessNode,OutProcessNodeがある
    /// </summary>
    public abstract class Node : INodeStatusListener,IDisposable
    {

        /// <summary>
        /// グラフのコネクター
        /// </summary>
        public INodeConnector Connector => ParentGraph.Connector;

        //グラフを取得する
        public readonly Graph ParentGraph;
        
        public event EventHandler<NodeConnectEventArgs> OnConnect;

        public event EventHandler<NodeConnectEventArgs> OnDisconnect;
        

        private bool _isDisposed;

        /// <summary>
        /// 何を入れてもいいデータ
        /// </summary>
        public IDictionary<string, object> Args = new Dictionary<string, object>();

        public Node(Graph parentGraph)
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
        /// 引数に指定されたノードの型が接続可能なものか確認する
        ///
        /// 例えば
        /// InItemNodeはOutItemNodeとしかつなげないし、
        /// OutProcessNodeはInProcessNodeとしかつなげない
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public abstract bool IsAttachableNodeType(Type type);

        /// <summary>
        /// 指定されたノードと接続できる状態かどうかを確認する
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public abstract bool CanAttach(Node node);

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
                Connector.DisconnectAllNode(this);
            }
        }
    }
}