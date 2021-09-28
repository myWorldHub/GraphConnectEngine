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
            AddNode(new InItemNode(this, typeof(object),"Object"));
            AddNode(new OutItemNode(this, typeof(string),1,"Text"));
            _updateText = updateText;
        }

        public override bool OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            //実行
            if (!_updateText(parameters[0].ToString()))
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

        public override string GetGraphName() => "Debug Text Graph";
    }
}