using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine
{
    /// <summary>
    /// プロセスを実行するためのインターフェース
    /// </summary>
    public interface IProcessCall
    {
        /// <summary>
        /// グラフを実行する
        ///
        /// OutItemNodeかOutProcessNode、またはそのサブクラスをsenderに指定する必要がある
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="args">実行データ</param>
        /// <returns></returns>
        Task<InvokeResult> Invoke(object sender, ProcessData args);

        /// <summary>
        /// 実行データなしにグラフを実行する
        /// </summary>
        /// <param name="args">実行データ</param>
        /// <param name="callOutProcess">OutProcessCallを起動するか</param>
        /// <param name="parameters">OnProcessCallに渡すパラメーター</param>
        /// <returns></returns>
        Task<InvokeResult> InvokeWithoutCheck(ProcessData args,bool callOutProcess, object[] parameters);

        /// <summary>
        /// グラフの実行の実装
        /// </summary>
        /// <param name="args">実行データ</param>
        /// <param name="parameters">InItemNodeから取得した値の配列</param>
        /// <returns></returns>
        Task<ProcessCallResult> OnProcessCall(ProcessData args,object[] parameters);
    }

    /// <summary>
    /// プロセスの実行結果用
    /// </summary>
    public class ProcessCallResult
    {
        /// <summary>
        /// 成功したか
        /// </summary>
        public readonly bool IsSucceeded;
        
        /// <summary>
        /// 結果の集合
        /// </summary>
        public readonly object[] Results;
        
        /// <summary>
        /// 次のノード
        /// </summary>
        public readonly OutProcessNode NextNode;

        private ProcessCallResult(bool isSucceeded, object[] results, OutProcessNode nextNode = null)
        {
            IsSucceeded = isSucceeded;
            Results = results;
            NextNode = nextNode;
        }

        /// <summary>
        /// 結果を失敗で生成する
        /// </summary>
        /// <returns></returns>
        public static ProcessCallResult Fail()
        {
            return new ProcessCallResult(false,null);
        }

        /// <summary>
        /// 結果を成功で生成する
        /// </summary>
        /// <param name="results">結果</param>
        /// <param name="nextNode">次のノード</param>
        /// <returns></returns>
        public static ProcessCallResult Success(object[] results,OutProcessNode nextNode)
        {
            return new ProcessCallResult(true, results, nextNode);
        }

        /// <summary>
        /// InvokeResultに変換する
        /// </summary>
        /// <returns></returns>
        public InvokeResult ToInvokeResult()
        {
            return (InvokeResult) this;
        }

        public static explicit operator InvokeResult(ProcessCallResult result)
        {
            return InvokeResult.Create(result.IsSucceeded,result.Results);
        }
        
        public override string ToString()
        {
            var a = IsSucceeded ? "Success" : "Fail";
            return $"ProcessCallResult<{a}> => Next[{NextNode}]";
        }
    }
}