using System;

namespace GraphConnectEngine.Core
{
    public class OutItemNode : GraphParentResolver,IItemTypeResolver
    {
        
        private Type _itemType;

        private Func<object> _action;

        public OutItemNode(GraphBase parentGraph, NodeConnector connector, Type itemType,Func<object> getValueFunc) : base(parentGraph,connector)
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
                foreach (var onode in otherNodes)
                {
                    Connector.DisconnectNode(this, onode);
                }
                
                _itemType = type;

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

        public bool TryGetValue<T>(out T result)
        {
            Object r = _action();
            if (r is T t)
            {
                result = t;
                return true;
            }
            else
            {
                result = default(T);
                return false;
            }
        }
        
    }
}