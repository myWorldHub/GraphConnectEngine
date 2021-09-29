using System;
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
            return new ProcessCallArgs(  $"{sender}_{Guid.NewGuid()}");
        }

        public ProcessCallArgs(object hash)
        {
            _value = hash.ToString();
        }

        /// <summary>
        /// 追加する
        /// </summary>
        /// <param name="nextHash"></param>
        /// <param name="isProcess"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryAdd(string nextHash,bool isProcess, out ProcessCallArgs result)
        {
            if (_value.Contains(nextHash))
            {
                result = null;
                return false;
            }
            result = new ProcessCallArgs(_value + ":" + (isProcess ? "Proc_" : "Item_") + nextHash);
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
            return string.Join(":", ienu);
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
        {

            Logger.Debug($"[CanGetItem]Start\nFrom  : {GetValue()}\nTarget: {parent.GetValue()}");
            
            //発火元が違う
            if (GetSender() != parent.GetSender())
            {
                Logger.Debug("[CanGetItem] Fail : Sender is not match.");
                return false;
            }

            var my = GetProcList();
            var you = parent.GetProcList();

            if (my == you)
            {
                Logger.Debug("[CanGetItem] Success : Same Args.");
                return true;
            }

            if (my.Length < you.Length)
            {
                Logger.Debug("[CanGetItem] Fail : Target is longer than FromArgs.");
                return false;
            }

            if (my.StartsWith(you))
            {
                Logger.Debug("[CanGetItem] Success");
                return true;
            }
            else
            {
                Logger.Debug($"[CanGetItem] Fail : Target is not same chain.\nFrom  : {my}\nTarget: {you}");
                return false;
            }
        }

        public string GetSender()
        {
            return _value.Split(':')[0];
        }

        public override string ToString()
        {
            return "Args : "+ GetValue();
        }
    }
}