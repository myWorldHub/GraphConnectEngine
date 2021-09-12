using System;
using System.Collections.Generic;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Core
{
    public abstract class GraphBase
    {

        public readonly InProcessNode InProcessNode;
        public readonly OutProcessNode OutProcessNode;

        private Tuple<ProcessCallArgs, bool, object[]> _cache;

        private List<InItemNode> _inItemNodes;
        private List<OutItemNode> _outItemNodes;

        public readonly NodeConnector Connector;

        /// <summary>
        /// 実行ステータスのリス名
        /// </summary>
        public event EventHandler<GraphStatusEventArgs> OnStatusChanged;

        public GraphBase(NodeConnector connector)
        {
            Connector = connector;
            
            InProcessNode = new InProcessNode(this);
            OutProcessNode = new OutProcessNode(this);

            _inItemNodes = new List<InItemNode>();
            _outItemNodes = new List<OutItemNode>();
        }

        public bool Invoke(object sender,ProcessCallArgs args,out object[] results)
        {
            string myHash = GetHashCode().ToString();
            string myName = $"{GetGraphName()}[{myHash}]";

            //イベント
            GraphEngineLogger.Debug($"{myName} is Invoked with\n{args}");
            OnStatusChanged?.Invoke(this,new GraphStatusEventArgs()
            {
                Type = GraphStatusEventArgs.EventType.InvokeCalled,
                Args = args
            });
            
            //キャッシュチェック
            if (_cache != null && args.CanGetItemOf(_cache.Item1))
            {
                //イベント
                GraphEngineLogger.Debug($"{myName} is Returning Cache\n{_cache.Item1} : {_cache.Item2} : {_cache.Item3}");
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
                    GraphEngineLogger.Debug($"{myName} is Returning NO Item : back with no cache");
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
                    GraphEngineLogger.Debug($"{myName} invoke Failed : Loop detected");
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
                    GraphEngineLogger.Debug($"{myName} Unknown Error");
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
                    GraphEngineLogger.Debug($"{myName} is Returning NO Item : Loop detected");
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
            GraphEngineLogger.Debug($"{myName} Invoke OnProcessCall in GraphBase with\n{nargs}");
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
            GraphEngineLogger.Debug($"{myName} Invoked OnProcessCall with result {procResult}");
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
            return InProcessNode.Connector.TryGetAnotherNode(InProcessNode, out var _);
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