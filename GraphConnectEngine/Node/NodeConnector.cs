using System;
using System.Collections.Generic;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// INodeConnectorのサンプル実装
    /// </summary>
    public class NodeConnector : INodeConnector
    {

        private readonly Dictionary<Node, List<Node>> _dict = new Dictionary<Node, List<Node>>();

        public event EventHandler<NodeConnectEventArgs> OnConnect;
        
        public event EventHandler<NodeConnectEventArgs> OnDisconnect;

        public void InvokeConnectEvent(NodeConnectEventArgs args)
        {
            OnConnect?.Invoke(this,args);
        }

        public void InvokeDisconnectEvent(NodeConnectEventArgs args)
        {
            OnDisconnect?.Invoke(this, args);
        }

        public T[] GetOtherNodes<T>(Node key)
        {
            if (!_dict.ContainsKey(key))
                return Array.Empty<T>();
            
            var list = new List<T>();
            foreach (var resolver in _dict[key])
                if (resolver is T t)
                    list.Add(t);

            return  list.ToArray();
        }
        
        public Node[] GetOtherNodes(Node key)
        {
            return _dict.ContainsKey(key) ? _dict[key].ToArray() : new Node[0];
        }
        
        public bool TryGetOtherNodes<T>(Node key, out T[] result)
        {
            result = null;
            
            if (!_dict.ContainsKey(key))
                return false;

            var list = new List<T>();
            foreach (var resolver in _dict[key])
                if (resolver is T t)
                    list.Add(t);

            result = list.ToArray();
            return list.Count != 0;
        }
        
        public bool TryGetOtherNodes(Node key, out Node[] result)
        {
            result = _dict.ContainsKey(key) ? _dict[key].ToArray() : null;
            return result != null;
        }
        
        public bool TryGetAnotherNode<T>(Node key, out T result) where T : Node
        {
            result = _dict.ContainsKey(key) ? _dict[key][0] as T: null;
            return result != null;
        }
        
        public bool TryGetAnotherNode(Node key, out Node result)
        {
            result = _dict.ContainsKey(key) ? _dict[key][0] : null;
            return result != null;
        }

        public bool IsConnected(Node node1, Node node2)
        {
            if (_dict.ContainsKey(node1))
            {
                return _dict[node1].Contains(node2);
            }
            
            return false;
        }
        
        public bool ConnectNode(Node node1, Node node2)
        {
            Logger.Debug("NodeConnector.ConnectNode().StartLog-------------------------");
            
            DumpNode(node1);
            DumpNode(node2);

            if (node1.Connector != this || node2.Connector != this)
            {
                Logger.Error("Error : Connector is not current Connector.");
                Logger.Debug("NodeConnector.ConnectNode().Fail");
                return false;
            }
            
            //接続チェック
            if (IsConnected(node1, node2) || IsConnected(node2,node1))
            {
                Logger.Error("Error : Already connected.");
                Logger.Debug("NodeConnector.ConnectNode().Fail");
                return false;
            }

            //つなげるNodeか確認する
            if (!node1.IsAttachableNodeType(node2.GetType()) || !node2.IsAttachableNodeType(node1.GetType()))
            {
                Logger.Error("Error : Node is not attachable Graph type.");
                Logger.Debug("NodeConnector.ConnectNode().Fail");
                return false;
            }

            //つながるかどうか確認
            if (!node1.CanAttach(node2) || !node2.CanAttach(node1))
            {
                Logger.Error("Error : Node is not attachable.");
                Logger.Debug("NodeConnector.ConnectNode().Fail");
                return false;
            }
            
            //接続
            Register(node1,node2);
            Register(node2,node1);
            
            Logger.Debug("NodeConnector.ConnectNode().Registered");
            
            InvokeConnectEvent(new NodeConnectEventArgs(node1, node2));
            
            //イベント発火
            node1.InvokeConnectEvent(new NodeConnectEventArgs(node1, node2));
            node2.InvokeConnectEvent(new NodeConnectEventArgs(node2, node1));
            
            return true;
        }
        
        public bool DisconnectNode(Node node1, Node node2)
        {

            if (node1.Connector != this || node2.Connector != this)
            {
                return false;
            }
            
            //接続確認
            if (!IsConnected(node1, node2) && !IsConnected(node2, node1))
            {
                return false;
            }
            
            //接続を切る
            Remove(node1,node2);
            Remove(node2,node1);
            
            InvokeDisconnectEvent(new NodeConnectEventArgs(node1,node2));
            
            //イベント発火
            node1.InvokeDisconnectEvent(new NodeConnectEventArgs(node1,node2));
            node2.InvokeDisconnectEvent(new NodeConnectEventArgs(node2,node1));
            
            return true;
        }
        
        public bool DisconnectAllNode(Node node)
        {
            if (node == null)
            {
                return false;
            }
            
            if (node.Connector != this)
            {
                return false;
            }

            var onodes = GetOtherNodes(node);
            foreach (var other in onodes)
            {
                if (other == null)
                    continue;
                DisconnectNode(other, node);
            }

            _dict.Remove(node);

            return true;
        }

        /// <summary>
        /// node1にnode2を繋ぐ(node1のみ)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        private void Register(Node node1, Node node2)
        {
            if (!_dict.ContainsKey(node1))
            {
                _dict[node1] = new List<Node>();
            }

            _dict[node1].Add(node2);
        }

        /// <summary>
        /// node1からnode2を切り離す(node1のみ)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        private void Remove(Node node1, Node node2)
        {
            if (_dict.ContainsKey(node1))
            {
                _dict[node1].Remove(node2);
                if (_dict[node1].Count == 0)
                {
                    _dict.Remove(node1);
                }
            }
        }

        /// <summary>
        /// ノードの情報をLoggerにダンプする
        /// </summary>
        /// <param name="node"></param>
        public void DumpNode(Node node)
        {
            Logger.Debug($"[NodeConnector] Dump of {node}");
            Logger.Debug($"Type : {node.GetType().FullName}");
            Logger.Debug($"Graph : {node.ParentGraph}");

            if (node.ParentGraph != null)
            {
                Logger.Debug($"Connector : {node.Connector}");
            }
            else
            {
                Logger.Debug($"Connector : Null");
            }

            if (node is InItemNode || node is OutItemNode)
            {
                Logger.Debug($"ItemType : ${((IItemTypeResolver)node).GetItemType().FullName}");
            }
        }
    }
}