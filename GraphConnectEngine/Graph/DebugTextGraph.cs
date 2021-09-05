using System;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class DebugTextGraph : GraphBase
    {
        public readonly InProcessNode InProcessNode;
        public readonly InItemNode InItemNode;

        private Action<string> _updateText;

        public DebugTextGraph(NodeConnector connector,Action<string> updateText)
        {
            InProcessNode = new InProcessNode(this,connector, OnCalled);
            InItemNode = new InItemNode(this, connector,typeof(object));
            _updateText = updateText;
        }

        private bool OnCalled(ProcessCallArgs args)
        {
            OutItemNode node;
            if (InItemNode.Connector.TryGetAnotherNode(InItemNode,out node))
            {
                if (node.TryGetValue<object>(out var obj))
                {
                    _updateText(obj.ToString());
                    return true;
                }
            }

            return false;
        }

        public override string GetGraphName()
        {
            return "Debug Text Graph";
        }

        public override bool IsProcessNodeConnected()
        {
            return true;
        }
    }
}