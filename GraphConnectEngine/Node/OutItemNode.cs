using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// InItemNodeにアイテムを渡すNode
    ///
    /// グラフの結果(配列)のインデックスを指定してアイテムを取得する
    /// </summary>
    public class OutItemNode : Node, IItemNode
    {

        private int _resultIndex;

        public IItemTypeResolver TypeResolver { get; }

        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="parentGraph">所属しているグラフ</param>
        /// <param name="typeResolver">型の定義クラス</param>
        /// <param name="resultIndex">グラフの結果のインデックス</param>
        public OutItemNode(IGraph parentGraph, IItemTypeResolver typeResolver,int resultIndex)
        {
            Graph = parentGraph;
            _resultIndex = resultIndex;
            TypeResolver = typeResolver;

            TypeResolver.Init(this);
        }

        public override bool IsAttachableNodeType(Type type)
        {
            var dt = typeof(InItemNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(INode anotherNode)
        {
            if (anotherNode is InItemNode inItemNode)
            {
                //ItemType Check
                Type otherItemType = inItemNode.TypeResolver.GetItemType();
                Type myItemType = TypeResolver.GetItemType();
                
                //void制限
                if (myItemType == typeof(void))
                {
                    return false;
                }

                return !(otherItemType != myItemType && !myItemType.IsSubclassOf(otherItemType));
            }

            return false;
        }

        /// <summary>
        /// グラフから値を取得する
        /// </summary>
        /// <param name="args">実行情報</param>
        /// <typeparam name="T">型</typeparam>
        /// <returns></returns>
        public async Task<ValueResult<T>> TryGetValue<T>(ProcessCallArgs args)
        {
            Logger.Debug($"OutItemNode.TryGetValue<{typeof(T).FullName}>().InvokeParentGraph");
                        
            var procResult = await Graph.Invoke(this, args);

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