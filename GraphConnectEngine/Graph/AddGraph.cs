using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class AddGraph : GraphBase
    {

        public readonly InItemNode InItemNode1;
        public readonly InItemNode InItemNode2;
        public readonly OutItemNode OutItemNode;

        public AddGraph(NodeConnector connector)
        {
            InItemNode1 = new InItemNode(this, connector,typeof(int));
            InItemNode2 = new InItemNode(this, connector,typeof(int));
            OutItemNode = new OutItemNode(this,connector,typeof(int),Get);
        }

        public bool Get(out object result)
        {
            int a = 0;
            int b = 0;
            result = null;

            OutItemNode outItem;
            if (!(InItemNode1.Connector.TryGetAnotherNode(InItemNode1,out outItem) && outItem.TryGetValue(out a)))
            {
                return false;
            }
            
            if (!(InItemNode2.Connector.TryGetAnotherNode(InItemNode2,out outItem) && outItem.TryGetValue(out b)))
            {
                return false;
            }

            result =  a + b;
            return true;
        }

        public override string GetGraphName()
        {
            return "Int Graph";
        }

        public override bool IsProcessNodeConnected()
        {
            return false;
        }
    }
}