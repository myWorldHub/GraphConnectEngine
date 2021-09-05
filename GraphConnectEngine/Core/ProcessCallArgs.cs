using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphConnectEngine.Core
{
    public class ProcessCallArgs
    {

        private string _value;

        /// <summary>
        /// 発火用
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static ProcessCallArgs Fire(object sender)
        {
            return new ProcessCallArgs(  sender.ToString()+"_"+DateTime.Now.Millisecond);
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
        public bool TryAdd(string nextHash,bool goBack, out ProcessCallArgs result)
        {
            if (_value.Contains(nextHash))
            {
                result = null;
                return false;
            }
            result = new ProcessCallArgs(_value + ":" + (goBack ? "Item_" : "Proc_") + nextHash);
            return true;
        }

        /// <summary>
        /// ハッシュ値を取得
        /// </summary>
        /// <returns></returns>
        public string GetValue()
        {
            return _value;
        }

        public bool Contains(string v)
        {
            return _value.Contains(v);
        }

        public string GetProcList()
        {
            var ienu = GetValue().Split(':').Where(s => s.StartsWith("Proc_"));

            string result = "";
            foreach (string s in ienu)
                result += s+":";

            return result;
        }

        public string GetItemList()
        {
            var ienu = GetValue().Split(':').Where(s => s.StartsWith("Item_"));

            string result = "";
            foreach (string s in ienu)
                result += s + ":";

            return result;
        }

        public bool CanGetItemOf(ProcessCallArgs parent)
        { //発火元が違う
            if (GetSender() != parent.GetSender())
            {
                return false;
            }

            var my = GetProcList();
            var you = parent.GetProcList();

            if (my == you)
            {
                return true;
            }

            if (my.Length < you.Length)
            {
                return false;
            }

            return my.StartsWith(you);
        }

        public string GetSender()
        {
            return _value.Split(':')[0];
        }
        
        
    }
}