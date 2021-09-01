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
            OutItemNode = new OutItemNode(this,connector,typeof(int),()=>Get());
        }

        public int Get()
        {
            int a = 0;
            int b = 0;

            OutItemNode outItem;
            if (InItemNode1.Connector.TryGetAnotherNode(InItemNode1,out outItem))
            {
                if (!outItem.TryGetValue(out a))
                {
                    a = 0;
                }
            }
            
            if (InItemNode2.Connector.TryGetAnotherNode(InItemNode2,out outItem))
            {
                if (!outItem.TryGetValue(out b))
                {
                    b = 0;
                }
            }
            
            return a + b;
        }

        public override string GetGraphName()
        {
            return "Int Graph";
        }
    }
}