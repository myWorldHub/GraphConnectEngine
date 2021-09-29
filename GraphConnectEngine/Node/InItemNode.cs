using System;
using System.Threading.Tasks;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// </summary>
    public class InItemNode : NodeBase,IItemTypeResolver
    {
        private Type _itemType;

        public event EventHandler<TypeChangeEventArgs> OnTypeChanged;

        private Func<Type, Type,bool> _typeCheckOnAtatch;

        private DefaultItemGetter _defaultItemGetter;

        public string Name => (string)Args["Name"];

        public InItemNode(GraphBase parentGraph, Type itemType,string name, DefaultItemGetter defaultItemGetter = null,Func<Type,Type,bool> typeCheckOnAtatchFunc = null) : base(parentGraph)
        {
            Args["Name"] = name;
            _itemType = itemType;
            _defaultItemGetter = defaultItemGetter;
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

        public override bool CanAttach(NodeBase resolver)
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

        public async Task<ValueResult<T>> GetItemFromConnectedNode<T>(ProcessCallArgs args)
        {
            if (Connector.TryGetAnotherNode(this, out OutItemNode node))
            {
                return await node.TryGetValue<T>(args);
            }
            else
            {
                if (_defaultItemGetter != null && _defaultItemGetter(out var r) && r is T rt)
                {
                    return ValueResult<T>.Success(rt);
                }
            }

            return ValueResult<T>.Fail();
        }

        public async Task<ValueResult<object>> GetItemFromConnectedNode(ProcessCallArgs args)
        {
            if (Connector.TryGetAnotherNode(this, out OutItemNode node))
            {
                var value = await node.TryGetValue<object>(args);
                if (value.IsSucceeded)
                {
                    var vtype = value.Value.GetType();
                    var mytype = GetItemType();
                    if (vtype == mytype || vtype.IsSubclassOf(mytype))
                    {
                        Logger.Debug("[InItemNode] Successful : Got item from OutItemNode.");
                        return value;
                    }
                    else
                    {
                        Logger.Debug($"[InItemNode] Fail : item from OutItemNode[{value.Value}] is neither {GetItemType().Name} nor subclass of mine.");
                        return ValueResult<object>.Fail();
                    }
                }
                else
                {
                    Logger.Debug("[InItemNode] Fail : OutItemNode returned value with Fail flag.");
                    return ValueResult<object>.Fail();
                }
            }
            else
            {
                if (_defaultItemGetter != null && _defaultItemGetter(out var r) && r is object rt)
                {
                    Logger.Debug("[InItemNode] Successful : used DefaultItemGetter.");
                    return ValueResult<object>.Success(rt);
                }
                else
                {
                    Logger.Debug("[InItemNode] Fail : No OutItemNode is connected.");
                }
            }

            return ValueResult<object>.Fail();
        }
    }
}