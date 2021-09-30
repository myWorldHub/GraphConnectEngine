namespace GraphConnectEngine.Core
{
    public class ValueResult<T>
    {
        public bool IsSucceeded;
        public T Value;
        
        private ValueResult()
        {
        }

        public static ValueResult<T> Create(bool isSucceeded, T value)
        {
            return new ValueResult<T>()
            {
                IsSucceeded = isSucceeded,
                Value = value
            };
        }

        public static ValueResult<T> Fail() => Create(false, default);

        public static ValueResult<T> Success(T value) => Create(true, value);

        public override string ToString()
        {
            var a = IsSucceeded ? "Success" : "Fail";
            return $"ValueResult<{a}>[{Value}]";
        }
    }
}