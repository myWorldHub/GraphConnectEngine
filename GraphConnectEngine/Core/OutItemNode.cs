using System;

namespace GraphConnectEngine.Core
{
    public class OutItemNode : GraphParentResolver,IItemTypeResolver
    {
        
        private Type _itemType;

        /// <summary>
        /// bool : 成功したかどうか
        /// result : 結果のオブジェクト
        /// </summary>
        public delegate bool TryGetItemResult(ProcessCallArgs args,out object result,bool goBack);
        
        private TryGetItemResult _action;
        public event EventHandler<TypeChangeEventArgs> OnTypeChanged;

        /// <summary>
        /// 結果のキャッシュ
        /// Sender,成功の可否,result
        /// </summary>
        private Tuple<ProcessCallArgs, bool, object> _cache;

        public OutItemNode(GraphBase parentGraph, NodeConnector connector, Type itemType, TryGetItemResult getValueFunc) : base(parentGraph,connector)
        {
            _action = getValueFunc;
            _itemType = itemType;
        }

        public Type GetItemType()
        {
            return _itemType;
        }

        public void SetItemType(Type type,bool tryReconnect = true)
        {
            
            if (_itemType == type)
                return;
            
            //接続確認
            if (Connector.TryGetOtherNodes(this, out var otherNodes))
            {
                //接続切る
                foreach (var onode in otherNodes)
                {
                    Connector.DisconnectNode(this, onode);
                }

                //event
                var from = _itemType;
                _itemType = type;
                OnTypeChanged?.Invoke(this, new TypeChangeEventArgs()
                {
                    From = from,
                    To = _itemType
                });

                //再接続
                foreach (var onode in otherNodes)
                {
                    Connector.ConnectNode(this, onode);
                }
            }
            else
            {
                _itemType = type;
            }
        }

        public override bool IsAttachableGraphType(Type type)
        {
            var dt = typeof(InItemNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(GraphParentResolver resolver)
        {
            if (resolver is InItemNode inItemNode)
            {
                //ItemType Check
                Type otherItemType = inItemNode.GetItemType();
                Type myItemType = GetItemType();
                
                //void制限
                if (myItemType == typeof(void))
                {
                    return false;
                }

                return !(otherItemType != myItemType && !myItemType.IsSubclassOf(otherItemType));
            }

            return false;
        }

        public bool TryGetValue<T>(ProcessCallArgs args,out T tResult,bool goBack)
        {
            string myHash = ParentGraph.GetHashCode().ToString();
            string myName = $"{ParentGraph.GetGraphName()}[{myHash}]";

            GraphEngineLogger.Debug($"{myName} Started to Getting Item with {goBack}\n{args}");
            //キャッシュチェック
            if (_cache != null && _cache.Item1.GetSender() == args.GetSender())
            {
                GraphEngineLogger.Debug($"{myName} is Returning Cache\n{_cache.Item1} : {_cache.Item2} : {_cache.Item3}");
                tResult = _cache.Item3 is T ? (T)_cache.Item3 : default(T);
                return _cache.Item2;
            }

            ProcessCallArgs nargs;
            
            if (goBack)
            {
                if (ParentGraph.IsConnectedInProcessNode())
                {
                    GraphEngineLogger.Debug($"{myName} is Returning NO Item : back with no cache");
                    //キャッシュがないとおかしい
                    tResult = default(T);
                    return false;
                }
                else
                {
                    if (!args.TryAdd(ParentGraph.GetHashCode().ToString(), true, out nargs))
                    {
                        GraphEngineLogger.Debug($"{myName} is Returning NO Item : back with loop");
                        //ループ検知
                        tResult = default(T);
                        return false;
                    }
                }
            }
            else
            {
                if (!args.TryAdd(ParentGraph.GetHashCode().ToString(), false, out nargs))
                {
                    GraphEngineLogger.Debug($"{myName} is Returning NO Item : go with loop");
                    //ループ検知
                    tResult = default(T);
                    return false;
                }
            }

            if (_action(nargs,out object result,goBack) && result is T t)
            {
                GraphEngineLogger.Debug($"{myName} is Returning Item : Success\nResult : {t}\nArgs : ${nargs}");
                
                tResult = t;
                _cache = new Tuple<ProcessCallArgs, bool, object>(nargs, true, tResult);
                return true;
            }
            else
            {
                GraphEngineLogger.Debug($"{myName} is Returning No Item : Success\nResult : Failed\nArgs : ${nargs}");
                
                tResult = default(T);
                _cache = new Tuple<ProcessCallArgs, bool, object>(nargs, false, null);
                return false;
            }

        }
        
    }
}