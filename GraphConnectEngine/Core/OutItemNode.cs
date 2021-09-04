using System;

namespace GraphConnectEngine.Core
{
    public class OutItemNode : GraphParentResolver,IItemTypeResolver
    {
        
        private Type _itemType;

        private TryGetProcessResult _action;
        public event EventHandler<TypeChangeEventArgs> OnTypeChanged;

        public OutItemNode(GraphBase parentGraph, NodeConnector connector, Type itemType,TryGetProcessResult getValueFunc) : base(parentGraph,connector)
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

        public bool TryGetValue<T>(out T tResult)
        {
            if (_action(out object result) && result is T t)
            {
                tResult = t;
                return true;
            }

            tResult = default(T);
            return false;
        }
        
    }
}