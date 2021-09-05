using System;

namespace GraphConnectEngine.Core
{
    public class ProcessCallArgs
    {
        
        private string _value;

        public const string NoProcessCall = "NoProcessCall";

        /// <summary>
        /// 発火用
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static ProcessCallArgs Fire(object sender)
        {
            return new ProcessCallArgs(sender.ToString()+"_"+DateTime.Now.Millisecond);
        }
        
        public ProcessCallArgs(object hash)
        {
            _value = hash.ToString();
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

            //TODO 実装と制限
            return false;
        }

        public string GetSender()
        {
            return _value.Split(':')[0];
        }
        
        
    }
}