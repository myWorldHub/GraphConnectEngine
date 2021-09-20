using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Operator
{
    public abstract class MidOperatorGraph : GraphBase
    {

        private Func<object, object, object> _computeFunc;
        
        private OperatorChecker.MidOperator _operator;
        
        public MidOperatorGraph(NodeConnector connector,OperatorChecker.MidOperator midOperator) : base(connector)
        {
            _operator = midOperator;
            
            AddNode(new InItemNode(this, typeof(object), (t1, t2) => TypeChecker(0, t1, t2)));
            AddNode(new InItemNode(this, typeof(object), (t1, t2) => TypeChecker(1, t1, t2)));

            AddNode(new OutItemNode(this, typeof(void), 0));
            AddNode(new OutItemNode(this, typeof(void), 1));
            AddNode(new OutItemNode(this, typeof(void), 2));

            InItemNodes[0].OnConnect += OnConnected;
            InItemNodes[1].OnConnect += OnConnected;
        }

        public void OnConnected(object _, NodeConnectEventArgs args)
        {
            //初期化
            _computeFunc = null;

            //getしておく
            var i1 = InItemNodes[0];
            var i2 = InItemNodes[1];
            var o1 = OutItemNodes[1];
            var o2 = OutItemNodes[2];
            var resultNode = OutItemNodes[0];

            //取得
            var senderNode = (InItemNode) args.SenderNode;
            var connectedNode = (OutItemNode) args.OtherNode;
            var otherInNode = senderNode == i1 ? i2 : i1;

            //確認
            (senderNode == i1 ? o1 : o2).SetItemType(connectedNode.GetItemType());
            if (Connector.TryGetAnotherNode(otherInNode, out OutItemNode oi))
            {
                if (OperatorChecker.CheckOperator(_operator, i1.GetItemType(), i2.GetItemType(),
                    out Type resultType, out _computeFunc))
                {
                    resultNode.SetItemType(resultType);
                }
                else
                {
                    _computeFunc = null;
                    resultNode.SetItemType(resultType);
                }
            }
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!InItemNodes[0].GetItemFromConnectedNode(args, out object a))
            {
                results = null;
                nextNode = null;
                return false;
            }

            if (!InItemNodes[1].GetItemFromConnectedNode(args, out object b))
            {
                results = null;
                nextNode = null;
                return false;
            }

            if (_computeFunc == null)
            {
                results = null;
                nextNode = null;
                return false;
            }

            object r = _computeFunc(a, b);

            results = new object[]
            {
                r,
                a,
                b
            };

            nextNode = OutProcessNode;
            return true;
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
            var b = OperatorChecker.CheckOperator(OperatorChecker.MidOperator.op_Addition,
                onode2.GetItemType(), anotherType, out Type _, out var __);

            return b;
        }
    }
}