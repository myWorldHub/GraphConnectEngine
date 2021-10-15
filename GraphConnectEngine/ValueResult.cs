namespace GraphConnectEngine
{
    /// <summary>
    /// 任意の型の値を表すためのクラス
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValueResult<T>
    {
        /// <summary>
        /// 成功したかどうか
        /// </summary>
        public bool IsSucceeded;
        
        /// <summary>
        /// 結果
        /// </summary>
        public T Value;
        
        private ValueResult(bool isSucceeded, T value)
        {
            IsSucceeded = isSucceeded;
            Value = value;
        }

        /// <summary>
        /// 生成する
        /// </summary>
        /// <param name="isSucceeded">成功したか</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public static ValueResult<T> Create(bool isSucceeded, T value)
        {
            return new ValueResult<T>(isSucceeded, value);
        }

        /// <summary>
        /// 失敗として生成する
        /// </summary>
        /// <returns></returns>
        public static ValueResult<T> Fail() => Create(false, default);

        /// <summary>
        /// 成功として生成する
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ValueResult<T> Success(T value) => Create(true, value);

        public override string ToString()
        {
            var a = IsSucceeded ? "Success" : "Fail";
            return $"ValueResult<{a}>[{Value}]";
        }
    }
}