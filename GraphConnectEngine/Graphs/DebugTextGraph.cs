using System;
using System.Threading.Tasks;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs
{
    /// <summary>
    /// InItemNode[0] : Objectの値をコンストラクタで指定した関数に渡す関数
    /// </summary>
    public class DebugTextGraph : Graph
    {
        
        private Func<string, Task<bool>> _updateText;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="updateText">InItemNode[0] : Objectの値を実行時に渡される関数</param>
        public DebugTextGraph(NodeConnector connector,Func<string, Task<bool>> updateText) : base(connector)
        {
            AddNode(new InItemNode(this, typeof(object),"Object"));
            AddNode(new OutItemNode(this, typeof(string),1,"Text"));
            _updateText = updateText;
        }

        public override async Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
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
            }, OutProcessNodes[0]);
        }

        public override string GetGraphName() => "Debug Text Graph";
    }
}