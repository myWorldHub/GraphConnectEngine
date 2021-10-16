using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// InItemNodeにアイテムを渡すNode
    ///
    /// グラフの結果(配列)のインデックスを指定してアイテムを取得する
    /// </summary>
    public class OutItemNode : Node,IItemTypeResolver
    {
        
        private Type _itemType;
        
        public event EventHandler<TypeChangeEventArgs> OnTypeChanged;

        private int _resultIndex;

        /// <summary>
        /// ノードを表す名前
        /// 型名やパラメーター名が相応しい
        /// </summary>
        public string Name => (string) GetData("Name");

        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="parentGraph">所属しているグラフ</param>
        /// <param name="itemType">型</param>
        /// <param name="resultIndex">グラフの結果のインデックス</param>
        /// <param name="name">名前</param>
        public OutItemNode(Graph parentGraph, Type itemType, int resultIndex,string name)
        {
            Graph = parentGraph;
            _resultIndex = resultIndex;
            _itemType = itemType;

            SetData("Name", name);
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
            if (Graph.Connector.TryGetOtherNodes(this, out var otherNodes))
            {
                //接続切る
                foreach (var onode in otherNodes)
                {
                    Graph.Connector.DisconnectNode(this, onode);
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
                    Graph.Connector.ConnectNode(this, onode);
                }
            }
            else
            {
                _itemType = type;
            }
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