using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphConnectEngine
{
    /// <summary>
    /// プロセスの実行情報を管理するクラス
    ///
    /// TODO 結果のデータも管理するのでメモリリーク注意
    /// </summary>
    public class ProcessCallArgs
    {

        private string _value;

        private Dictionary<string, ProcessCallResult> _cache;
        private Dictionary<string, ProcessCallArgs> _args;


        private ProcessCallArgs(object hash, Dictionary<string, ProcessCallResult> cache, Dictionary<string, ProcessCallArgs> args)
        {
            _value = hash.ToString();
            _cache = cache;
            _args = args;
        }
        
        /// <summary>
        /// 発火する
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static ProcessCallArgs Fire(object sender)
        {
            return new ProcessCallArgs($"{sender}_{Guid.NewGuid()}", new Dictionary<string, ProcessCallResult>(),
                new Dictionary<string, ProcessCallArgs>());
        }

        /// <summary>
        /// データを追加する
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
            result = new ProcessCallArgs(_value + ":" + (isProcess ? "Proc_" : "Item_") + nextHash,_cache,_args);
            return true;
        }

        /// <summary>
        /// 値を取得する
        /// </summary>
        /// <returns></returns>
        public string GetValue()
        {
            return _value;
        }

        /// <summary>
        /// 値がstringを含むかどうか
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool Contains(string v)
        {
            return _value.Contains(v);
        }

        /// <summary>
        /// プロセスによって実行された結果のリストを取得する
        /// </summary>
        /// <returns></returns>
        public string GetProcList()
        {
            var ienu = GetValue().Split(':').Where(s => s.StartsWith("Proc_"));
            return string.Join(":", ienu);
        }

        /// <summary>
        /// アイテムノードによって実行された結果のリストを取得する
        /// </summary>
        /// <returns></returns>
        public string GetItemList()
        {
            var ienu = GetValue().Split(':').Where(s => s.StartsWith("Item_"));

            string result = "";
            foreach (string s in ienu)
                result += s + ":";

            return result;
        }

        /// <summary>
        /// グラフの結果を取得できないか試す
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public ProcessCallResult TryGetResultOf(Graph graph)
        {

            Logger.Debug($"ProcessCallArgs.TryGetResultOf() > Trying to get cache of {graph.Id} \n From : {GetValue()}");

            if (!_args.ContainsKey(graph.Id))
            {
                Logger.Debug("ProcessCallArgs.TryGetResultOf() >  Fail : No Cache is registered for this graph.");
                return null;
            }

            var targetArgs = _args[graph.Id];
            
            //発火元が違う
            if (GetSender() != targetArgs.GetSender())
            {
                Logger.Debug("ProcessCallArgs.TryGetResultOf() >  Fail : Sender is not match.");
                return null;
            }

            var my = GetProcList();
            var you = targetArgs.GetProcList();

            if (my == you)
            {
                Logger.Debug("ProcessCallArgs.TryGetResultOf() >  Success : Same Args.");
                return _cache[graph.Id];
            }

            //TODO callのid振りが2桁以上になったらおかしくなるかも？
            if (my.Length < you.Length)
            {
                Logger.Debug("ProcessCallArgs.TryGetResultOf() >  Fail : Target is longer than FromArgs.");
                return null;
            }

            if (my.StartsWith(you))
            {
                Logger.Debug("ProcessCallArgs.TryGetResultOf() >  Success");
                return _cache[graph.Id];
            }
            else
            {
                Logger.Debug($"ProcessCallArgs.TryGetResultOf() >  Fail : Target is not same chain. \n From  : {my}\nTarget: {you}");
                return null;
            }
        }

        /// <summary>
        /// キャッシュを設定
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="result"></param>
        public void SetResult(Graph graph, ProcessCallResult result)
        {
            _cache[graph.Id] = result;
            _args[graph.Id] = this;
            Logger.Debug($"ProcessCallArgs.SetResult() >  Registered Result cache of Graph<{graph.Id}> \n with : {GetValue()}");
        }

        /// <summary>
        /// 発火したグラフを取得する
        /// </summary>
        /// <returns></returns>
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