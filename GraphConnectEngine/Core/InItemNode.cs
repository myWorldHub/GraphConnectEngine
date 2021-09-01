using System;

namespace GraphConnectEngine.Core
{
    /// <summary>
    /// </summary>
    public class InItemNode : GraphParentResolver,IItemTypeResolver
    {
        private Type _itemType;

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
    }
}