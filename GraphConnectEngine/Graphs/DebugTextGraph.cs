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
        
        private Func<string,Task> PrintFunc;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public DebugTextGraph(string id) : base(id)
        {
            AddNode(new InItemNode(this, new ItemTypeResolver(typeof(object),"Object")));
            AddNode(new OutItemNode(this, new ItemTypeResolver(typeof(string),"Text"),1));
        }

        /// <summary>
        /// テキストを受け取る関数を設定する
        /// </summary>
        /// <param name="function"></param>
        public void SetPrintFunction(Func<string,Task> function)
        {
            PrintFunc = function;
        }

        public override async Task<ProcessCallResult> OnProcessCall(ProcessData args, object[] parameters)
        {
            var obj = parameters[0];
            var str = obj.ToString();

            //実行
            if(PrintFunc != null)
            {
                await PrintFunc(str);
            }

            return ProcessCallResult.Success(new []
            {
                obj,
                str
            }, OutProcessNodes[0]);
        }

        public override string GraphName => "DebugText";
    }
}
