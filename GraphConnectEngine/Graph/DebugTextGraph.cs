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
            OutItemNode node;
            if (InItemNode.Connector.TryGetAnotherNode(InItemNode, out node))
            {
                if (node.TryGetValue<object>(args, out var obj))
                {
                    _updateText(obj.ToString());
                    nextNode = OutProcessNode;
                    return true;
                }
            }

            nextNode = null;
            return false;
        }

        public override string GetGraphName()
        {
            return "Debug Text Graph";
        }
    }
}