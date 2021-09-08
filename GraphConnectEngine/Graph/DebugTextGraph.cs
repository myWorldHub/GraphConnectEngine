using System;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class DebugTextGraph : GraphBase
    {
        private Func<string,bool> _updateText;

        public DebugTextGraph(NodeConnector connector,Func<string,bool> updateText) : base(connector)
        {
            AddItemNode(new InItemNode(this, connector, typeof(object)));
            AddItemNode(new OutItemNode(this, connector, typeof(string),1));
            _updateText = updateText;
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!GetInItemNode(0).GetItemFromConnectedNode(args, out object obj))
            {
                nextNode = null;
                results = null;
                return false;
            }
            
            _updateText(obj.ToString());
            
            results = new object[]
            {
                obj,
                obj.ToString()
            };
            nextNode = OutProcessNode;
            return true;    
        }

        public override string GetGraphName()
        {
            return "Debug Text Graph";
        }
    }
}