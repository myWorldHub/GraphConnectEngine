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

        protected override bool OnProcessCall(ProcessCallArgs args, out OutProcessNode nextNode)
        {
            if (InItemNode.GetItemFromConnectedNode(args, out object obj))
            {
                _updateText(obj.ToString());
                nextNode = OutProcessNode;
                return true;    
            }
            else
            {
                nextNode = null;
                return false;
            }
        }

        public override string GetGraphName()
        {
            return "Debug Text Graph";
        }
    }
}