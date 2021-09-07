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
            OutItemNode = new OutItemNode(this,connector,typeof(int),Get);
        }

        private bool Get(ProcessCallArgs args,out object result)
        {
            if (!InItemNode1.GetItemFromConnectedNode(args,out int a))
            {
                result = null;
                return false;
            }

            if (!InItemNode1.GetItemFromConnectedNode(args, out int b))
            {
                result = null;
                return false;
            }

            result =  a + b;
            return true;
        }

        protected override bool OnProcessCall(ProcessCallArgs args,out OutProcessNode nextNode)
        {
            OutItemNode.TryGetValue<int>(args, out var result);
            nextNode = OutProcessNode;
            return true;
        }

        public override string GetGraphName()
        {
            return "Add Graph";
        }
    }
}