using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// OutItemNodeから値を渡されるノード
    /// </summary>
    public class InItemNode : Node, IItemNode
    {

        private Func<Type, Type,bool> _typeCheckOnAtatch;

        private DefaultItemGetter _defaultItemGetter;

        public IItemTypeResolver TypeResolver { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="parentGraph">親のグラフ</param>
        /// <param name="typeResolver">型の定義クラス</param>
        /// <param name="defaultItemGetter">OutItemNodeと繋がっていない場合,この関数の返り値を使う</param>
        /// <param name="typeCheckOnAtatchFunc">CanAttachで独自の型チェックを利用したい時に指定する</param>
        public InItemNode(IGraph parentGraph,IItemTypeResolver typeResolver, DefaultItemGetter defaultItemGetter = null,Func<Type,Type,bool> typeCheckOnAtatchFunc = null)
        {
            Graph = parentGraph;
            TypeResolver = typeResolver;
            _defaultItemGetter = defaultItemGetter;
            _typeCheckOnAtatch = typeCheckOnAtatchFunc;

            TypeResolver.Init(this);
        }

        public override bool IsAttachableNodeType(Type type)
        {
            var dt = typeof(OutItemNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(INode anotherNode)
        {
            if (anotherNode is OutItemNode outItemNode)
            {
                //ItemType Check
                Type otherItemType = outItemNode.TypeResolver.GetItemType();
                Type myItemType = TypeResolver.GetItemType();

                //void制限
                if (myItemType == typeof(void))
                {
                    return false;
                }

                //1対1関係
                if (Graph.Connector.GetOtherNodes(this).Length != 0)
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

        /// <summary>
        /// 繋がっているOutItemNodeから値をもらってくる
        ///
        /// Tに任意の型を指定できて、型チェックしたうえで結果を返す
        /// </summary>
        /// <param name="args">プロセス情報</param>
        /// <typeparam name="T">型</typeparam>
        /// <returns></returns>
        public async Task<ValueResult<T>> GetItemFromConnectedNode<T>(ProcessCallArgs args)
        {
            if (Graph.Connector.TryGetAnotherNode(this, out OutItemNode node))
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

        /// <summary>
        /// 繋がっているOutItemNodeから値をもらってくる
        ///
        /// 自分に設定されている型、またはそれがSubclassになるものの場合結果を返す
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<ValueResult<object>> GetItemFromConnectedNode(ProcessCallArgs args)
        {
            Logger.Debug("InItemNode.GerItemFromConnectedNode().Invoked");
            
            if (Graph.Connector.TryGetAnotherNode(this, out OutItemNode node))
            {
                var value = await node.TryGetValue<object>(args);
                if (value.IsSucceeded)
                {
                    var vtype = value.Value.GetType();
                    var mytype = TypeResolver.GetItemType();
                    
                    if (vtype == mytype || vtype.IsSubclassOf(mytype))
                    {
                        Logger.Debug("InItemNode.GerItemFromConnectedNode().ReturnProcessResult");
                        return value;
                    }
                    else
                    {
                        Logger.Error($"Error : item from OutItemNode[{value.Value}] is neither {TypeResolver.GetItemType().Name} nor subclass of mine");
                        Logger.Debug("InItemNode.GerItemFromConnectedNode().ReturnFail");
                    }
                }
                else
                {
                    Logger.Debug("InItemNode.GerItemFromConnectedNode().ReturnFail > OutItemNode.FailFlag");
                }
            }
            else
            {
                if (_defaultItemGetter != null && _defaultItemGetter(out var r) && r is object rt)
                {
                    Logger.Debug("InItemNode.GerItemFromConnectedNode().ReturnDefaultItemGetterResult");
                    return ValueResult<object>.Success(rt);
                }
                else
                {
                    Logger.Debug("InItemNode.GerItemFromConnectedNode().ReturnFail > NoItemResult");
                }
            }

            return ValueResult<object>.Fail();
        }
    }
}