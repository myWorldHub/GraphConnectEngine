using System;

namespace GraphConnectEngine.Nodes
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

        public void SetItemType(Type type)
        {
            if (_itemType == type)
                return;

            //event
            var from = _itemType;
            _itemType = type;
            OnTypeChanged?.Invoke(this, new TypeChangeEventArgs()
            {
                From = from,
                To = _itemType
            });
        }
    }
}
