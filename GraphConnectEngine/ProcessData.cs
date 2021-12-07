using System;
using System.Collections.Generic;
using System.Linq;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine
{
    /// <summary>
    /// プロセスの実行情報を管理するクラス
    ///
    /// TODO 結果のデータも管理するのでメモリリーク注意
    /// </summary>
    public class ProcessData
    {

        private string _chain;

        private IDictionary<string, ProcessCallResult> _cache;
        private IDictionary<string, ProcessData> _args;
        private IDictionary<string, object> _dummyData;

        public readonly INodeConnector Connector;


        private ProcessData(object hash,in INodeConnector connector,IDictionary<string, ProcessCallResult> cache, IDictionary<string, ProcessData> args, IDictionary<string,object> dummyData)
        {
            _chain = hash.ToString();
            _cache = cache;
            _args = args;
            _dummyData = dummyData;
            Connector = connector;
        }
        
        /// <summary>
        /// 発火する
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static ProcessData Fire(object sender,in INodeConnector connector)
        {
            return new ProcessData($"{sender}_{Guid.NewGuid()}", connector,new Dictionary<string, ProcessCallResult>(),
                new Dictionary<string, ProcessData>(),new Dictionary<string, object>());
        }

        /// <summary>
        /// データを追加する
        /// </summary>
        /// <param name="nextHash"></param>
        /// <param name="isProcess"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryAdd(string nextHash,bool isProcess, out ProcessData result)
        {
            if (_chain.Contains(nextHash))
            {
                result = null;
                return false;
            }
            result = new ProcessData(_chain + ":" + (isProcess ? "Proc_" : "Item_") + nextHash, Connector, _cache,_args,_dummyData);
            return true;
        }

        /// <summary>
        /// 値がstringを含むかどうか
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool Contains(string v)
        {
            return _chain.Contains(v);
        }

        /// <summary>
        /// プロセスによって実行された結果のリストを取得する
        /// </summary>
        /// <returns></returns>
        public string GetProcList()
        {
            var ienu = _chain.Split(':').Where(s => s.StartsWith("Proc_"));
            return string.Join(":", ienu);
        }

        /// <summary>
        /// アイテムノードによって実行された結果のリストを取得する
        /// </summary>
        /// <returns></returns>
        public string GetItemList()
        {
            var ienu = _chain.Split(':').Where(s => s.StartsWith("Item_"));

            string result = "";
            foreach (string s in ienu)
                result += s + ":";

            return result;
        }

        /// <summary>
        /// グラフの結果を取得できないか試す
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="force"></param>
        /// <returns></returns>
        public ProcessCallResult TryGetResultOf(IGraph graph,bool force = false)
        {

            Logger.Debug($"ProcessCallArgs.TryGetResultOf() > Trying to get cache of {graph.Id} \n From : {_chain}");

            if (!_args.ContainsKey(graph.Id))
            {
                Logger.Debug("ProcessCallArgs.TryGetResultOf() >  Fail : No Cache is registered for this graph.");
                return null;
            }

            if (force)
            {
                return _cache[graph.Id];
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
        public void SetResult(IGraph graph, ProcessCallResult result)
        {
            _cache[graph.Id] = result;
            _args[graph.Id] = this;
            Logger.Debug($"ProcessCallArgs.SetResult() >  Registered Result cache of Graph<{graph.Id}> \n with : {_chain}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object GetDummyData(string key)
        {
            return _dummyData.ContainsKey(key) ? _dummyData[key] : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetDummyData(string key, object value)
        {
            _dummyData[key] = value;
        }

        /// <summary>
        /// 発火したグラフを取得する
        /// </summary>
        /// <returns></returns>
        public string GetSender()
        {
            return _chain.Split(':')[0];
        }

        public override string ToString()
        {
            return "Args : "+ _chain;
        }
    }
}
