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
        public MidOperatorGraph(INodeConnector connector,OperatorChecker.MidOperator midOperator) : base(connector)
        {
            _operator = midOperator;

            IItemTypeResolver resolver1 = new ItemTypeResolver(typeof(object), "A");
            IItemTypeResolver resolver2 = new ItemTypeResolver(typeof(object), "B");
            IItemTypeResolver resolver3 = new ItemTypeResolver(typeof(void), "Result");
            
            AddNode(new InItemNode(this, resolver1,typeCheckOnAtatchFunc:(t1, t2) => TypeChecker(0, t1, t2)));
            AddNode(new InItemNode(this, resolver2,typeCheckOnAtatchFunc: (t1, t2) => TypeChecker(1, t1, t2)));

            AddNode(new OutItemNode(this, resolver1,0));
            AddNode(new OutItemNode(this, resolver2,1));
            AddNode(new OutItemNode(this, resolver3, 2));

            InItemNodes[0].OnConnect += OnConnected;
            InItemNodes[1].OnConnect += OnConnected;
        }

        private void OnConnected(object _, NodeConnectEventArgs args)
        {
            //初期化
            _computeFunc = null;

            //getしておく
            var i1 = InItemNodes[0];
            var i2 = InItemNodes[1];
            var o1 = OutItemNodes[0];
            var o2 = OutItemNodes[1];
            var resultNode = OutItemNodes[2];

            //取得
            var senderNode = (InItemNode) args.SenderNode;
            var connectedNode = (OutItemNode) args.OtherNode;
            var otherInNode = senderNode == i1 ? i2 : i1;

            //確認
            (senderNode == i1 ? o1 : o2).TypeResolver.SetItemType(connectedNode.TypeResolver.GetItemType());
            if (Connector.TryGetAnotherNode(otherInNode, out OutItemNode oi))
            {
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
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            if (_computeFunc == null)
                return Task.FromResult(ProcessCallResult.Fail());

            object a = parameters[0];
            object b = parameters[1];
            object r = _computeFunc(a, b);

            return Task.FromResult(ProcessCallResult.Success(new[]
            {
                a,
                b,
                r
            },OutProcessNodes[0]));
        }

        private bool TypeChecker(int sender, Type myType, Type anotherType)
        {
            //既にくっついてる
            if (Connector.TryGetAnotherNode(InItemNodes[sender], out OutItemNode onode1))
                return false;

            //両方ともくっついてない
            if (!Connector.TryGetAnotherNode(InItemNodes[(sender + 1) % 2], out OutItemNode onode2))
                return true;

            //片方繋がってる
            var b = OperatorChecker.CheckOperator(_operator,
                onode2.TypeResolver.GetItemType(), anotherType, out Type _, out var __);

            return b;
        }
    }
}