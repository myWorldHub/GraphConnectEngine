using System;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Node
{
    public class OutItemNode : GraphParentResolver,IItemTypeResolver
    {
        
        private Type _itemType;
        
        public event EventHandler<TypeChangeEventArgs> OnTypeChanged;

        private int _resultIndex;

        public string Name => (string) Args["Name"];

        public OutItemNode(GraphBase parentGraph, Type itemType, int resultIndex,string name) : base(parentGraph)
        {
            Args["Name"] = name;
            _resultIndex = resultIndex;
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

        public bool TryGetValue<T>(ProcessCallArgs args,out T tResult)
        {
            var procResult = ParentGraph.Invoke(this, args, out var results);

            if (procResult)
            {
                if (results.Length >= _resultIndex + 1)
                {
                    if (results[_resultIndex] is T t)
                    {
                        tResult = t;
                        return true;
                    }
                }
                else
                {
                    Logger.Error($"TryGetValue Unexpected Index");
                }
            }

            tResult = default(T);
            return false;
        }
        
    }
}