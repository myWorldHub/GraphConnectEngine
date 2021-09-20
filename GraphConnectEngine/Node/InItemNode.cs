using System;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// </summary>
    public class InItemNode : GraphParentResolver,IItemTypeResolver
    {
        private Type _itemType;

        public event EventHandler<TypeChangeEventArgs> OnTypeChanged;

        private Func<Type, Type,bool> _typeCheckOnAtatch;

        public DefaultItemGetter DefaultItemGetter;

        public InItemNode(GraphBase parentGraph, Type itemType, Func<Type,Type,bool> typeCheckOnAtatchFunc = null) : base(parentGraph)
        {
            _itemType = itemType;
            _typeCheckOnAtatch = typeCheckOnAtatchFunc;
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
                //接続を切る
                foreach (var onode in otherNodes)
                {
                    Connector.DisconnectNode(this, onode);
                }

                //event
                var from = _itemType;
                _itemType = type;
                OnTypeChanged?.Invoke(this,new TypeChangeEventArgs()
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
            var dt = typeof(OutItemNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(GraphParentResolver resolver)
        {
            if (resolver is OutItemNode outItemNode)
            {
                //ItemType Check
                Type otherItemType = outItemNode.GetItemType();
                Type myItemType = GetItemType();

                //void制限
                if (myItemType == typeof(void))
                {
                    return false;
                }

                //1対1関係
                if (Connector.GetOtherNodes(this).Length != 0)
                {
                    return false;
                }

                //型チェック
                if (_typeCheckOnAtatch != null)
                {
                    if (!_typeCheckOnAtatch(myItemType, otherItemType))
                    {
                        return false;
                    }
                }
                else
                {
                    if (otherItemType != myItemType && !otherItemType.IsSubclassOf(myItemType))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public bool GetItemFromConnectedNode<T>(ProcessCallArgs args,out T result)
        {
            if (Connector.TryGetAnotherNode(this, out OutItemNode node))
            {
                if (node.TryGetValue(args, out result))
                {
                    return true;
                }
            }
            else
            {
                if (DefaultItemGetter(out var r) && r is T rt)
                {
                    result = rt;
                    return true;
                }
            }

            result = default(T);
            return false;
        }
    }
}