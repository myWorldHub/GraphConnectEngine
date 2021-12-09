using System;
using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// 二項演算を行うグラフ
    /// </summary>
    public abstract class MidOperatorGraph : Graph
    {

        private Func<object, object, object> _computeFunc;
        
        private OperatorChecker.MidOperator _operator;
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="midOperator">演算子</param>
        public MidOperatorGraph(string id, OperatorChecker.MidOperator midOperator) : base(id)
        {
            _operator = midOperator;

            IItemTypeResolver resolver1 = new ItemTypeResolver(typeof(object), "A");
            IItemTypeResolver resolver2 = new ItemTypeResolver(typeof(object), "B");
            IItemTypeResolver resolver3 = new ItemTypeResolver(typeof(void), "Result");

            AddNode(new InItemNode(this, resolver1, enableTypeCheck: false));
            AddNode(new InItemNode(this, resolver2, enableTypeCheck: false));

            AddNode(new OutItemNode(this, resolver3,0));

            InItemNodes[0].OnConnect += OnConnected;
            InItemNodes[1].OnConnect += OnConnected;
        }

        private void OnConnected(object _, NodeConnectEventArgs args)
        {
            //初期化
            _computeFunc = null;

            //getしておく
            var resultNode = OutItemNodes[0];

            //取得 完全評価
            if (!args.Connector.TryGetAnotherNode(InItemNodes[0], out OutItemNode o1) |
                !args.Connector.TryGetAnotherNode(InItemNodes[1], out OutItemNode o2))
            {
                _computeFunc = null;
                return;
            }

            if (OperatorChecker.CheckOperator(_operator, o1.TypeResolver.GetItemType(), o2.TypeResolver.GetItemType(),
                out Type resultType, out _computeFunc))
            {
                resultNode.TypeResolver.SetItemType(resultType);
            }
            else
            {
                _computeFunc = null;
                resultNode.TypeResolver.SetItemType(typeof(void));
            }
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessData args, object[] parameters)
        {
            if (_computeFunc == null)
                return Task.FromResult(ProcessCallResult.Fail());

            object r = _computeFunc(parameters[0], parameters[1]);
            return Task.FromResult(ProcessCallResult.Success(new[] {r}, OutProcessNodes[0]));
        }
    }
}
