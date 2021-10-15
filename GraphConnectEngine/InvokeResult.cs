namespace GraphConnectEngine
{
    
    /// <summary>
    /// グラフの実行結果を取得するためのクラス
    /// </summary>
    public class InvokeResult
    {
        /// <summary>
        /// 成功したかどうか
        /// </summary>
        public readonly bool IsSucceeded;
        
        /// <summary>
        /// 結果
        /// </summary>
        public readonly object[] Results;

        private InvokeResult(bool isSucceeded, object[] results)
        {
            IsSucceeded = isSucceeded;
            Results = results;
        }

        /// <summary>
        /// 生成する
        /// </summary>
        /// <param name="isSucceeded"></param>
        /// <param name="results"></param>
        /// <returns></returns>
        public static InvokeResult Create(bool isSucceeded, object[] results)
        {
            return new InvokeResult(isSucceeded, results);
        }

        /// <summary>
        /// 結果を失敗で生成する
        /// </summary>
        /// <returns></returns>
        public static InvokeResult Fail() => Create(false, null);
        
        /// <summary>
        /// 結果を成功で生成する
        /// </summary>
        /// <param name="results"></param>
        /// <returns></returns>
        public static InvokeResult Success(object[] results) => Create(true, results);

        public override string ToString()
        {
            var a = IsSucceeded ? "Success" : "Fail";
            return $"InvokeResult<{a}>";
        }
    }
}