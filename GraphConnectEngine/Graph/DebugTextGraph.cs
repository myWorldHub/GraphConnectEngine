using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

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

        protected override bool OnProcessCall(ProcessCallArgs args, object[] param, out object[] results,
            out OutProcessNode nextNode)
        {
            var obj = param[0];

            //実行
            if (!_updateText(obj.ToString()))
            {
                nextNode = null;
                results = null;
                return false;
            }
            
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