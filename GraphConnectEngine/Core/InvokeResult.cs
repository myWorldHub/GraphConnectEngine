namespace GraphConnectEngine.Core
{
    public class InvokeResult
    {
        public bool IsSucceeded;
        public object[] Results;

        private InvokeResult()
        {

        }

        public static InvokeResult Create(bool isSucceeded, object[] results)
        {
            return new InvokeResult()
            {
                IsSucceeded = isSucceeded,
                Results = results
            };
        }

        public static InvokeResult Fail() => Create(false, null);

        public static InvokeResult Success(object[] results) => Create(true, results);

        public override string ToString()
        {
            var a = IsSucceeded ? "Success" : "Fail";
            return $"InvokeResult<{a}>";
        }
    }
}