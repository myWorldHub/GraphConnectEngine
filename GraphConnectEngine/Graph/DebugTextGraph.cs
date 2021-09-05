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

        public override bool OnProcessCall(ProcessCallArgs args)
        {
            throw new NotImplementedException();
        }

        public override string GetGraphName()
        {
            return "Debug Text Graph";
        }
    }
}