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
            int a = 0;
            int b = 0;
            result = null;

            OutItemNode outItem;
            if (!(InItemNode1.Connector.TryGetAnotherNode(InItemNode1,out outItem) && outItem.TryGetValue(args,out a)))
            {
                return false;
            }
            
            if (!(InItemNode2.Connector.TryGetAnotherNode(InItemNode2,out outItem) && outItem.TryGetValue(args,out b)))
            {
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