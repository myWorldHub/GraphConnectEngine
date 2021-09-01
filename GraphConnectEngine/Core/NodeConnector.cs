using System;
using System.Collections.Generic;

namespace GraphConnectEngine.Core
{
    /// <summary>
    /// GraphParentResolver同時がどのように繋がっているか管理するためのもの
    /// GraphParentResolverから触るもので、普通触らない
    ///
    /// ConnectNode => IsAttachableGraphType => CanAttach => Register => OnConnect
    /// 
    /// </summary>
    public class NodeConnector
    {

        private readonly Dictionary<GraphParentResolver, List<GraphParentResolver>> _dict = new Dictionary<GraphParentResolver, List<GraphParentResolver>>();

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T[] GetOtherNodes<T>(GraphParentResolver key)
        {
            if (!_dict.ContainsKey(key))
                return Array.Empty<T>();
            
            var list = new List<T>();
            foreach (var resolver in _dict[key])
                if (resolver is T t)
                    list.Add(t);

            return  list.ToArray();
        }
        /// <summary>
        /// 繋がれているノードを取得する
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public GraphParentResolver[] GetOtherNodes(GraphParentResolver key)
        {
            return _dict.ContainsKey(key) ? _dict[key].ToArray() : new GraphParentResolver[0];
        }

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool TryGetOtherNodes<T>(GraphParentResolver key, out T[] result)
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
        
        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryGetOtherNodes(GraphParentResolver key, out GraphParentResolver[] result)
        {
            result = _dict.ContainsKey(key) ? _dict[key].ToArray() : null;
            return result != null;
        }

        /// <summary>
        /// 繋がれているノードをキャストして取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool TryGetAnotherNode<T>(GraphParentResolver key, out T result) where T : GraphParentResolver
        {
            result = _dict.ContainsKey(key) ? _dict[key][0] as T: null;
            return result != null;
        }
        
        /// <summary>
        /// 繋がれているノードを取得する
        /// 繋がれていない場合はfalseを返す
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryGetAnotherNode(GraphParentResolver key, out GraphParentResolver result)
        {
            result = _dict.ContainsKey(key) ? _dict[key][0] : null;
            return result != null;
        }

        /// <summary>
        /// node1にnode2を繋ぐ(node1のみ)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        private void Register(GraphParentResolver node1, GraphParentResolver node2)
        {
            if (!_dict.ContainsKey(node1))
            {
                _dict[node1] = new List<GraphParentResolver>();
            }

            _dict[node1].Add(node2);
        }

        /// <summary>
        /// node1からnode2を切り離す(node1のみ)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        private void Remove(GraphParentResolver node1, GraphParentResolver node2)
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
        /// node1がnode2と繋がっているかチェック(node1のみ)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public bool IsConnected(GraphParentResolver node1, GraphParentResolver node2)
        {
            if (_dict.ContainsKey(node1))
            {
                return _dict[node1].Contains(node2);
            }
            
            return false;
        }

        /// <summary>
        /// ノードとノードを繋ぐ
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public bool ConnectNode(GraphParentResolver node1, GraphParentResolver node2)
        {

            if (node1.Connector != this || node2.Connector != this)
            {
                return false;
            }
            
            //接続チェック
            if (IsConnected(node1, node2) || IsConnected(node2,node1))
            {
                return false;
            }

            //つなげるResolverか確認する
            if (!node1.IsAttachableGraphType(node2.GetType()) || !node2.IsAttachableGraphType(node1.GetType()))
            {
                return false;
            }

            //つながるかどうか確認
            if (!node1.CanAttach(node2) || !node2.CanAttach(node1))
            {
                return false;
            }
            
            //接続
            Register(node1,node2);
            Register(node2,node1);
            
            //イベント発火
            node1.InvokeConnectEvent(new NodeConnectEventArgs()
            {
                OtherNode = node2
            });
            
            node2.InvokeConnectEvent(new NodeConnectEventArgs()
            {
                OtherNode = node1
            });

            return true;
        }

        /// <summary>
        /// ノードを切断する
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public bool DisconnectNode(GraphParentResolver node1, GraphParentResolver node2)
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
            
            //イベント発火
            node1.InvokeDisconnectEvent(new NodeConnectEventArgs()
            {
                OtherNode = node2
            });
            
            node2.InvokeDisconnectEvent(new NodeConnectEventArgs()
            {
                OtherNode = node1
            });
            
            return true;
        }
        
    }
}