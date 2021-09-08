using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    /// <summary>
    /// サンプルグラフ
    /// Int32同士を足す
    /// </summary>
    public class AddGraph : GraphBase
    {

        public readonly InItemNode InItemNode1;
        public readonly InItemNode InItemNode2;
        public readonly OutItemNode OutItemNode;

        public AddGraph(NodeConnector connector) : base(connector)
        {
            InItemNode1 = new InItemNode(this, connector,typeof(int));
            InItemNode2 = new InItemNode(this, connector,typeof(int));
            
            OutItemNode = new OutItemNode(this,connector,typeof(int),0);
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!InItemNode1.GetItemFromConnectedNode(args, out int a))
            {
                results = null;
                nextNode = null;
                return false;
            }

            if (!InItemNode1.GetItemFromConnectedNode(args, out int b))
            {
                results = null;
                nextNode = null;
                return false;
            }

            results = new object[]
            {
                a+b,
                a,
                b
            };
            
            nextNode = OutProcessNode;
            return true;
        }

        public override string GetGraphName()
        {
            return "Add Graph";
        }
    }
}