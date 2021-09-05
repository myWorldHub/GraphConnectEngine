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
            //キャッシュチェック
            if (_cache != null && _cache.Item1.GetSender() == args.GetSender())
            {
                tResult = _cache.Item3 is T ? (T)_cache.Item3 : default(T);
                return _cache.Item2;
            }

            ProcessCallArgs nargs;
            
            if (goBack)
            {
                if (GetParentGraph().IsConnectedInProcessNode())
                {
                    //キャッシュがないとおかしい
                    tResult = default(T);
                    return false;
                }
                else
                {
                    if (!args.TryAdd(GetParentGraph().GetHashCode().ToString(), true, out nargs))
                    {
                        //ループ検知
                        tResult = default(T);
                        return false;
                    }
                }
            }
            else
            {
                if (!args.TryAdd(GetParentGraph().GetHashCode().ToString(), false, out nargs))
                {
                    //ループ検知
                    tResult = default(T);
                    return false;
                }
            }

            if (_action(nargs,out object result,goBack) && result is T t)
            {
                tResult = t;
                _cache = new Tuple<ProcessCallArgs, bool, object>(nargs, true, tResult);
                return true;
            }
            else
            {
                tResult = default(T);
                _cache = new Tuple<ProcessCallArgs, bool, object>(nargs, false, null);
                return false;
            }

        }
        
    }
}