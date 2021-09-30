using System;
using Cysharp.Threading.Tasks;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph
{
    public class DebugTextGraph : GraphBase
    {
        
        private Func<string, UniTask<bool>> _updateText;

        public DebugTextGraph(NodeConnector connector,Func<string, UniTask<bool>> updateText) : base(connector)
        {
            AddNode(new InItemNode(this, typeof(object),"Object"));
            AddNode(new OutItemNode(this, typeof(string),1,"Text"));
            _updateText = updateText;
        }

        public override async UniTask<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            var obj = parameters[0];
            var str = obj.ToString();
            
            //実行
            if (!await _updateText(str))
                return ProcessCallResult.Fail();

            return ProcessCallResult.Success(new []
            {
                obj,
                str
            }, OutProcessNode);
        }

        public override string GetGraphName() => "Debug Text Graph";
    }
}