using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Operator
{
    /// <summary>
    /// サンプルグラフ
    /// Int32同士を足す
    /// </summary>
    public class AddGraph : GraphBase
    {

        private Type _resultType;

        public AddGraph(NodeConnector connector) : base(connector)
        {
            AddNode(new InItemNode(this, typeof(object),(t1,t2) => TypeChecker(0,t1,t2)));
            AddNode(new InItemNode(this, typeof(object), (t1, t2) => TypeChecker(1, t1, t2)));

            AddNode(new OutItemNode(this, typeof(void), 0));
            AddNode(new OutItemNode(this, typeof(void), 1));
            AddNode(new OutItemNode(this, typeof(void), 2));

            var i1 = GetInItemNode(0);
            var i2 = GetInItemNode(1);

            i1.OnConnect += (_, args) =>
            {
                GetOutItemNode(1).SetItemType(((OutItemNode)args.OtherNode).GetItemType());
                if (Connector.TryGetAnotherNode(i2, out OutItemNode oi))
                {
                    GetOutItemNode(0).SetItemType(_resultType);
                }
            };
            i2.OnConnect += (_, args) =>
            {
                GetOutItemNode(2).SetItemType(((OutItemNode)args.OtherNode).GetItemType());
                if (Connector.TryGetAnotherNode(i1, out OutItemNode oi))
                {
                    GetOutItemNode(0).SetItemType(_resultType);
                }
            };
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!GetInItemNode(0).GetItemFromConnectedNode(args, out object a))
            {
                results = null;
                nextNode = null;
                return false;
            }

            if (!GetInItemNode(1).GetItemFromConnectedNode(args, out object b))
            {
                results = null;
                nextNode = null;
                return false;
            }

            if (!PrimitiveOperatorChecker.TryAddition(a, b, out object r))
            {
                results = null;
                nextNode = null;
                return false;
            }

            results = new object[]
            {
                r,
                a,
                b
            };
            
            nextNode = OutProcessNode;
            return true;
        }
        
        private bool TypeChecker(int sender,Type myType,Type anotherType)
        {
            Connector.TryGetAnotherNode(GetInItemNode(0), out OutItemNode onode1);
            Connector.TryGetAnotherNode(GetInItemNode(1), out OutItemNode onode2);
            
            //両方くっついてない
            if (onode1 == onode2 && onode2 == null)
                return true;

            //片方繋がってる
            var n1 = sender == 1 ? onode1 : onode2;
            
            //TODO プリミティブ型のみ
            var b = PrimitiveOperatorChecker.CheckAddition(n1.GetItemType(), anotherType, out Type result);
            
            _resultType = result ?? typeof(void);
            
            return b;
        }

        public override string GetGraphName()
        {
            return "Add Graph";
        }
    }
}