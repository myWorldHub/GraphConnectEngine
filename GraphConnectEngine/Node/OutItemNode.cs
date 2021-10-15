using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Node
{
    public class OutItemNode : Node,IItemTypeResolver
    {
        
        private Type _itemType;
        
        public event EventHandler<TypeChangeEventArgs> OnTypeChanged;

        private int _resultIndex;

        public string Name => (string) Args["Name"];

        public OutItemNode(Graph parentGraph, Type itemType, int resultIndex,string name) : base(parentGraph)
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

        public override bool CanAttach(Node resolver)
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

        public async Task<ValueResult<T>> TryGetValue<T>(ProcessCallArgs args)
        {
            Logger.Debug($"OutItemNode.TryGetValue<{typeof(T).FullName}>().InvokeParentGraph");
                        
            var procResult = await ParentGraph.Invoke(this, args);

            if (procResult.IsSucceeded)
            {
                if (procResult.Results.Length >= _resultIndex + 1)
                {
                    var value = procResult.Results[_resultIndex];
                    if (value is T t)
                    {
                        Logger.Debug($"OutItemNode.TryGetValue<{typeof(T).FullName}>().ReturnResult<{t}>");
                        return ValueResult<T>.Success(t);
                    }
                    else
                    {
                        Logger.Debug($"OutItemNode.TryGetValue<{typeof(T).FullName}>().ReturnTypeIsNotMatch<{value}>");
                    }
                }
                else
                {
                    Logger.Error("IndexOutOfRangeError");
                    Logger.Error($"OutItemNode.TryGetValue<{typeof(T).FullName}>().CheckIndex");
                }
            }
            else
            {
                Logger.Error($"OutItemNode.TryGetValue<{typeof(T).FullName}>().ProcessFailed");
            }

            return ValueResult<T>.Fail();
        }

        
    }
}