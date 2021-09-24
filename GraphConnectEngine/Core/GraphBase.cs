using System;
using System.Collections.Generic;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Core
{
    public abstract class GraphBase : IDisposable
    {

        public readonly NodeConnector Connector;

        /// <summary>
        /// Nodes
        /// </summary>
        public InProcessNode InProcessNode => InProcessNodes[0];
        public OutProcessNode OutProcessNode => OutProcessNodes[0];

        public readonly List<InProcessNode> InProcessNodes = new List<InProcessNode>();
        public readonly List<OutProcessNode> OutProcessNodes = new List<OutProcessNode>();
        public readonly List<InItemNode> InItemNodes = new List<InItemNode>();
        public readonly List<OutItemNode> OutItemNodes = new List<OutItemNode>();

        private Tuple<ProcessCallArgs, bool, object[]> _cache;

        /// <summary>
        /// 実行ステータスのリス名
        /// </summary>
        public event EventHandler<GraphStatusEventArgs> OnStatusChanged;

        public GraphBase(NodeConnector connector)
        {
            Connector = connector;

            AddNode(new InProcessNode(this));
            AddNode(new OutProcessNode(this));
        }

        public bool Invoke(object sender,ProcessCallArgs args,out object[] results)
        {
            string myHash = GetHashCode().ToString();
            string myName = $"{GetGraphName()}[{myHash}]";

            //イベント
            Logger.Debug($"{myName} is Invoked with\n{args}");
            OnStatusChanged?.Invoke(this,new GraphStatusEventArgs()
            {
                Type = GraphStatusEventArgs.EventType.InvokeCalled,
                Args = args
            });
            
            //キャッシュチェック
            if (_cache != null && args.CanGetItemOf(_cache.Item1))
            {
                //イベント
                Logger.Debug($"{myName} is Returning Cache\n{_cache.Item1} : {_cache.Item2} : {_cache.Item3}");
                OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                {
                    Type = GraphStatusEventArgs.EventType.CacheUsed,
                    Args = args
                });
                
                results = _cache.Item3;
                return _cache.Item2;
            }

            ProcessCallArgs nargs;

            if (IsConnectedInProcessNode())
            {
                if (sender is OutItemNode)
                {
                    //キャッシュがないとおかしい
                    //イベント
                    Logger.Debug($"{myName} is Returning NO Item : back with no cache");
                    OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                    {
                        Type = GraphStatusEventArgs.EventType.CacheError,
                        Args = args
                    });
                    
                    results = Array.Empty<object>();
                    return false;
                }

                //ループ検知
                if (!args.TryAdd(myHash, true, out nargs))
                {
                    //イベント
                    Logger.Debug($"{myName} invoke Failed : Loop detected");
                    OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                    {
                        Type = GraphStatusEventArgs.EventType.LoopDetected,
                        Args = args
                    });
                    
                    results = Array.Empty<object>();
                    return false;
                }
            }
            else
            {
                if (sender is OutProcessNode)
                {
                    //イベント
                    //繋がってないのに呼ばれるってどういうこと？
                    Logger.Debug($"{myName} Unknown Error");
                    OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                    {
                        Type = GraphStatusEventArgs.EventType.UnknownError,
                        Args = args
                    });
                    
                    results = Array.Empty<object>();
                    return false;
                }
                
                //ループ検知
                if (!args.TryAdd(GetHashCode().ToString(), false, out nargs))
                {
                    //イベント
                    Logger.Debug($"{myName} is Returning NO Item : Loop detected");
                    OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                    {
                        Type = GraphStatusEventArgs.EventType.LoopDetected,
                        Args = args
                    });
                    
                    results = Array.Empty<object>();
                    return false;
                }
            }
            
            //イベント
            Logger.Debug($"{myName} Invoke OnProcessCall in GraphBase with\n{nargs}");
            OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
            {
                Type = GraphStatusEventArgs.EventType.ProcessStart,
                Args = nargs
            });

            //Invoke
            bool procResult = OnProcessCall(nargs, out results, out var nextNode);

            //キャッシュする
            _cache = new Tuple<ProcessCallArgs, bool, object[]>(nargs, procResult, results ?? Array.Empty<object>());

            //イベント
            Logger.Debug($"{myName} Invoked OnProcessCall with result {procResult}");
            OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
            {
                Type = procResult ? GraphStatusEventArgs.EventType.ProcessSuccess : GraphStatusEventArgs.EventType.ProcessFail,
                Args = nargs
            });
            
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

        protected void AddNode(InItemNode node)
        {
            InItemNodes.Add(node);
        }

        protected void AddNode(OutItemNode node)
        {
            OutItemNodes.Add(node);
        }

        protected void AddNode(InProcessNode node)
        {
            InProcessNodes.Add(node);
        }

        protected void AddNode(OutProcessNode node)
        {
            OutProcessNodes.Add(node);
        }

        /// <summary>
        /// InProcessNodeが繋がれているかどうかを確認する
        /// </summary>
        /// <returns></returns>
        public virtual bool IsConnectedInProcessNode()
        {
            return InProcessNode.Connector.TryGetAnotherNode(InProcessNode, out var _);
        }

        public void Dispose()
        {
            foreach (var n in InProcessNodes)
                n.Dispose();
            foreach (var n in OutProcessNodes)
                n.Dispose();
            foreach (var n in InItemNodes)
                n.Dispose();
            foreach (var n in OutItemNodes)
                n.Dispose();
        }
    }

    public class GraphStatusEventArgs : EventArgs
    {
        public enum EventType
        {
            InvokeCalled,
            ProcessStart,
            ProcessSuccess,
            ProcessFail,
            CacheUsed,
            CacheError,
            LoopDetected,
            UnknownError
        }

        public EventType Type;
        public ProcessCallArgs Args;
    }
}