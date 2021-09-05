namespace GraphConnectEngine.Core
{
    public class ProcessCallArgs
    {
        
        private string _value;

        public const string NoProcessCall = "NoProcessCall";
        
        public ProcessCallArgs(string senderHash)
        {
            _value = senderHash;
        }

        /// <summary>
        /// 追加する
        /// </summary>
        /// <param name="nextHash"></param>
        /// <returns></returns>
        public ProcessCallArgs Add(string nextHash)
        {
            return new ProcessCallArgs(_value + ":" + nextHash);
        }

        /// <summary>
        /// ハッシュ値を取得
        /// </summary>
        /// <returns></returns>
        public string GetValue()
        {
            return _value;
        }

        public bool CanGetItemOf(ProcessCallArgs parent)
        {
            var my = GetValue().Split(':');
            var pa = GetValue().Split(':');

            //TODO
            return false;
        }
        
        
    }
}