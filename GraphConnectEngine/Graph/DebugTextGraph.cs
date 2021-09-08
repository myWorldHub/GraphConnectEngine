using System;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class DebugTextGraph : GraphBase
    {
        public readonly InItemNode InItemNode;

        private Action<string> _updateText;

        public DebugTextGraph(NodeConnector connector,Action<string> updateText) : base(connector)
        {
            InItemNode = new InItemNode(this, connector,typeof(object));
            _updateText = updateText;
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!InItemNode.GetItemFromConnectedNode(args, out object obj))
            {
                nextNode = null;
                results = null;
                return false;
            }
            
            _updateText(obj.ToString());
            
            results = new object[]
            {
                obj
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