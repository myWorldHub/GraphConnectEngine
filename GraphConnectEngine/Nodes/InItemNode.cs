using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Nodes
{
    /// <summary>
    /// OutItemNodeから値を渡されるノード
    /// </summary>
    public class InItemNode : Node, IItemNode
    {

        private DefaultItemGetter _defaultItemGetter;

        public IItemTypeResolver TypeResolver { get; }

        private bool _enableTypeCheck;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="parentGraph">親のグラフ</param>
        /// <param name="typeResolver">型の定義クラス</param>
        /// <param name="defaultItemGetter">OutItemNodeと繋がっていない場合,この関数の返り値を使う</param>
        public InItemNode(IGraph parentGraph,IItemTypeResolver typeResolver, DefaultItemGetter defaultItemGetter = null,bool enableTypeCheck = true)
        {
            Graph = parentGraph;
            TypeResolver = typeResolver;
            _defaultItemGetter = defaultItemGetter;
            _enableTypeCheck = enableTypeCheck;

            TypeResolver.Init(this);
        }

        public override bool IsAttachableNodeType(Type type)
        {
            var dt = typeof(OutItemNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(INodeConnector connector,INode anotherNode)
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
                if (connector.GetOtherNodes(this).Length != 0)
                {
                    return false;
                }

                //型チェック
                if (_enableTypeCheck) {
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
        public async Task<ValueResult<T>> GetItemFromConnectedNode<T>(ProcessData proc)
        {
            if (proc.Connector.TryGetAnotherNode(this, out OutItemNode node))
            {
                return await node.TryGetValue<T>(proc);
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
        public async Task<ValueResult<object>> GetItemFromConnectedNode(ProcessData proc)
        {
            Logger.Debug("InItemNode.GerItemFromConnectedNode().Invoked");
            
            if (proc.Connector.TryGetAnotherNode(this, out OutItemNode node))
            {
                var value = await node.TryGetValue<object>(proc);
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

        /// <summary>
        /// ノードがデフォルト値を取得するための関数を持っているか確認する
        /// </summary>
        /// <returns></returns>
        public bool HasDefaultItemGetter()
        {
            return _defaultItemGetter != null;
        }
    }
}
