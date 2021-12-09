using System;
using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

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
        public DebugTextGraph(string id,Func<string, Task<bool>> updateText) : base(id)
        {
            AddNode(new InItemNode(this, new ItemTypeResolver(typeof(object),"Object")));
            AddNode(new OutItemNode(this, new ItemTypeResolver(typeof(string),"Text"),1));
            _updateText = updateText;
        }

        public override async Task<ProcessCallResult> OnProcessCall(ProcessData args, object[] parameters)
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

        public override string GraphName => "DebugText";
    }
}
