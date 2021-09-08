using System;
using System.Collections.Generic;

namespace GraphConnectEngine.Core
{
    public abstract class GraphBase
    {

        public readonly InProcessNode InProcessNode;
        public readonly OutProcessNode OutProcessNode;

        private Tuple<ProcessCallArgs, bool, object[]> _cache;

        private List<InItemNode> _inItemNodes;
        private List<OutItemNode> _outItemNodes;

        public GraphBase(NodeConnector connector)
        {
            InProcessNode = new InProcessNode(this, connector);
            OutProcessNode = new OutProcessNode(this, connector);

            _inItemNodes = new List<InItemNode>();
            _outItemNodes = new List<OutItemNode>();
        }

        public bool Invoke(object sender,ProcessCallArgs args,out object[] results)
        {
            string myHash = GetHashCode().ToString();
            string myName = $"{GetGraphName()}[{myHash}]";

            GraphEngineLogger.Debug($"{myName} is Invoked with\n{args}");
            
            //キャッシュチェック
            if (_cache != null && args.CanGetItemOf(_cache.Item1))
            {
                GraphEngineLogger.Debug(
                    $"{myName} is Returning Cache\n{_cache.Item1} : {_cache.Item2} : {_cache.Item3}");
                results = _cache.Item3;
                return _cache.Item2;
            }

            ProcessCallArgs nargs;

            if (IsConnectedInProcessNode())
            {
                if (sender is OutItemNode itemNode)
                {
                    //キャッシュがないとおかしい
                    GraphEngineLogger.Debug($"{myName} is Returning NO Item : back with no cache");
                    results = Array.Empty<object>();
                    return false;
                }

                //ループ検知
                if (!args.TryAdd(myHash, true, out nargs))
                {
                    GraphEngineLogger.Debug($"{myName} invoke Failed : Loop detected");
                    results = Array.Empty<object>();
                    return false;
                }
            }
            else
            {
                if (sender is OutProcessNode)
                {
                    //繋がってないのに呼ばれるってどういうこと？
                    results = Array.Empty<object>();
                    GraphEngineLogger.Debug($"{myName} Unknown Error");
                    return false;
                }
                
                //ループ検知
                if (!args.TryAdd(GetHashCode().ToString(), false, out nargs))
                {
                    GraphEngineLogger.Debug($"{myName} is Returning NO Item : Loop detected");
                    results = Array.Empty<object>();
                    return false;
                }
            }
            
            //Invoke
            GraphEngineLogger.Debug($"{myName} Invoke OnProcessCall in GraphBase with\n{nargs}");
            bool procResult = OnProcessCall(nargs, out results, out var nextNode);
            GraphEngineLogger.Debug($"{myName} Invoked OnProcessCall with result {procResult}");

            //キャッシュする
            _cache = new Tuple<ProcessCallArgs, bool, object[]>(nargs, procResult, results ?? Array.Empty<object>());
            
            //OutProcessなら実行する
            if (procResult && sender is OutProcessNode)
            {
                nextNode?.CallProcess(args);
            }

            return procResult;
        }

        /// <summary>
        /// ProcessCallで呼ばれる
        /// 実装では必ずOutItemをキャッシュさせる
        /// </summary>
        /// <param name="args"></param>
        /// <param name="results"></param>
        /// <param name="nextNode"></param>
        /// <returns></returns>
        protected abstract bool OnProcessCall(ProcessCallArgs args,out object[] results,out OutProcessNode nextNode);

        /// <summary>
        /// グラフ名を取得する
        /// </summary>
        /// <returns></returns>
        public abstract string GetGraphName();

        protected void AddItemNode(InItemNode itemNode)
        {
            _inItemNodes.Add(itemNode);
        }

        protected void AddItemNode(OutItemNode itemNode)
        {
            _outItemNodes.Add(itemNode);
        }

        public InItemNode GetInItemNode(int index)
        {
            return _inItemNodes[index];
        }

        public OutItemNode GetOutItemNode(int index)
        {
            return _outItemNodes[index];
        }

        public InItemNode[] GetInItemNodes()
        {
            return _inItemNodes.ToArray();
        }

        public OutItemNode[] GetOutItemNodes()
        {
            return _outItemNodes.ToArray();
        }

        /// <summary>
        /// InProcessNodeが繋がれているかどうかを確認する
        /// </summary>
        /// <returns></returns>
        public virtual bool IsConnectedInProcessNode()
        {
            return InProcessNode.Connector.TryGetAnotherNode(InProcessNode, out GraphParentResolver resolver);
        }
    }
}