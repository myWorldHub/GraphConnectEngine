using System;

namespace GraphConnectEngine.Core
{
    /// <summary>
    /// </summary>
    public class InItemNode : GraphParentResolver,IItemTypeResolver
    {
        private Type _itemType;

        public event EventHandler<TypeChangeEventArgs> OnTypeChanged;

        public event EventHandler<ItemObtainedEventArgs> OnItemObtained;

        public InItemNode(GraphBase parentGraph, NodeConnector connector, Type itemType) : base(parentGraph,connector)
        {
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

                if (otherItemType != myItemType && !otherItemType.IsSubclassOf(myItemType))
                {
                    return false;
                }

                return Connector.GetOtherNodes(this).Length == 0;
            }

            return false;
        }

        public bool GetItemFromConnectedNode<T>(ProcessCallArgs args,out T result)
        {
            if (Connector.TryGetAnotherNode(this, out OutItemNode node))
            {
                if (node.TryGetValue<T>(args, out result))
                {
                    return true;
                }
            }

            result = default(T);
            return false;
        }
    }

    public class ItemObtainedEventArgs : EventArgs
    {
        public bool Result;
        public object Item;
        public Type Type;
    }
}