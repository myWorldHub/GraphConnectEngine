using System;

namespace GraphConnectEngine.Node
{
    public class ItemTypeResolver : IItemTypeResolver
    {
        private Type _itemType;

        public event EventHandler<TypeChangeEventArgs> OnTypeChanged;

        private INode _node;

        public string ItemName { get; }

        public ItemTypeResolver(Type type,string itemName)
        {
            _itemType = type;
            ItemName = itemName;
        }

        public void Init(INode node)
        {
            _node = node;
        }

        public Type GetItemType()
        {
            return _itemType;
        }

        public void SetItemType(Type type, bool tryReconnect = true)
        {

            if (_itemType == type)
                return;

            //接続確認
            if (_node.Graph.Connector.TryGetOtherNodes(_node, out var otherNodes))
            {
                //接続を切る
                foreach (var onode in otherNodes)
                {
                    _node.Graph.Connector.DisconnectNode(_node, onode);
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
                if (tryReconnect)
                {
                    foreach (var onode in otherNodes)
                    {
                        _node.Graph.Connector.ConnectNode(_node, onode);
                    }
                }
            }
            else
            {
                _itemType = type;
            }
        }
    }
}