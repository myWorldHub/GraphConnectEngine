using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine
{
    /// <summary>
    /// グラフ
    ///
    /// フローベースプログラミングの実行の一単位となるもの
    /// グラフにはノードが存在していて、違うグラフとノードを繋いで値を加工する
    /// </summary>
    public abstract class Graph : IGraph,IDisposable
    {
        public string Id { get; set; }

        public abstract string GraphName { get; }
        
        public INodeConnector Connector { get; }
        
        public IList<InProcessNode> InProcessNodes { get; }
        public IList<OutProcessNode> OutProcessNodes { get; }
        public IList<InItemNode> InItemNodes { get; }
        public IList<OutItemNode> OutItemNodes { get; }
        
        public event EventHandler<GraphStatusEventArgs> OnStatusChanged;


        /// <summary>
        /// コンストラクタ
        /// IdはコンストラクタでHashCodeで割り当てられる
        ///
        /// ID : 識別用のID(全てのグラフのインスタンスでユニークである必要がある)
        /// </summary>
        /// <param name="connector">コネクター</param>
        /// <param name="createInProcessNode">InProcessNodeを自動生成する</param>
        /// <param name="createOutProcessNode">OutProcessNodeを自動生成する</param>
        public Graph(INodeConnector connector,bool createInProcessNode = true,bool createOutProcessNode = true)
        {
            Id = GetHashCode().ToString();
            
            Connector = connector;
            
            InProcessNodes = new List<InProcessNode>();
            OutProcessNodes = new List<OutProcessNode>();
            InItemNodes = new List<InItemNode>();
            OutItemNodes = new List<OutItemNode>();

            if(createInProcessNode)
                AddNode(new InProcessNode(this));
            
            if(createOutProcessNode)
                AddNode(new OutProcessNode(this));
        }

        public async Task<InvokeResult> Invoke(object sender,ProcessCallArgs args)
        {
            string myName = $"{GraphName}[{Id}]";

            //イベント
            Logger.Debug($"GraphBase<{myName}>.Invoke()");
            
            OnStatusChanged?.Invoke(this,new GraphStatusEventArgs()
            {
                Type = GraphStatusEventArgs.EventType.InvokeCalled,
                Args = args
            });
            
            //キャッシュチェック
            var cache = args.TryGetResultOf(this);
            if (cache != null)
            {
                //イベント
                Logger.Debug($"GraphBase<{myName}>.Invoke().ReturnCache : {cache.Results} > Next[{cache.NextNode}]");
                
                OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                {
                    Type = GraphStatusEventArgs.EventType.CacheUsed,
                    Args = args
                });

                return cache.ToInvokeResult();
            }

            ProcessCallArgs nargs;

            if (IsConnectedInProcessNode())
            {
                if (sender is OutItemNode)
                {
                    //キャッシュがないとおかしい
                    //イベント
                    Logger.Error("BackWithNoCacheException");
                    Logger.Debug($"GraphBase<{myName}>.Invoke().ReturnFailResult");
                    
                    OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                    {
                        Type = GraphStatusEventArgs.EventType.CacheError,
                        Args = args
                    });

                    return InvokeResult.Fail();
                }

                //ループ検知
                if (!args.TryAdd(Id, true, out nargs))
                {
                    //イベント
                    Logger.Error("LoopException");
                    Logger.Debug($"GraphBase<{myName}>.Invoke().ReturnFailResult");
                    
                    OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                    {
                        Type = GraphStatusEventArgs.EventType.LoopDetected,
                        Args = args
                    });
                    
                    return InvokeResult.Fail();
                }
            }
            else
            {
                if (sender is OutProcessNode)
                {
                    //イベント
                    //繋がってないのに呼ばれるってどういうこと？
                    Logger.Error("UnknownException");
                    Logger.Debug($"GraphBase<{myName}>.Invoke().ReturnFailResult");
                    
                    OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                    {
                        Type = GraphStatusEventArgs.EventType.UnknownError,
                        Args = args
                    });

                    return InvokeResult.Fail();
                }
                
                //ループ検知
                if (!args.TryAdd(Id, false, out nargs))
                {
                    //イベント
                    Logger.Error("LoopException");
                    Logger.Debug($"GraphBase<{myName}>.Invoke().ReturnFailResult");
                    
                    OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
                    {
                        Type = GraphStatusEventArgs.EventType.LoopDetected,
                        Args = args
                    });
                    
                    return InvokeResult.Fail();
                }
            }

            //パラメータを取得する
            object[] parameters = new object[InItemNodes.Count];

            for (int i=0;i<InItemNodes.Count;i++)
            {
                //取得
                Logger.Debug($"GraphBase<{myName}>.Invoke().StartGettingParameter[{i}]");
                var res = await InItemNodes[i].GetItemFromConnectedNode(nargs);
                
                //失敗
                if (!res.IsSucceeded)
                {
                    Logger.Debug($"GraphBase<{myName}>.Invoke().FailedGettingParameter[{i}] > {res}");
                    
                    OnStatusChanged?.Invoke(this,new GraphStatusEventArgs()
                    {
                        Type = GraphStatusEventArgs.EventType.ParamError,
                        Args = nargs
                    });
                    
                    nargs.SetResult(this,ProcessCallResult.Fail());
                    
                    return InvokeResult.Fail();
                }

                Logger.Debug($"GraphBase<{myName}>.Invoke().SavedParameterValue");
                parameters[i] = res.Value;
            }
            
            //イベント
            OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
            {
                Type = GraphStatusEventArgs.EventType.ProcessStart,
                Args = nargs
            });

            //Invoke
            Logger.Debug($"GraphBase<{myName}>.Invoke().InvokeOnProcessCall");
            ProcessCallResult procResult = await OnProcessCall(nargs, parameters);
            Logger.Debug($"GraphBase<{myName}>.Invoke().InvokedOnProcessCall<{procResult}>");

            //キャッシュする
            nargs.SetResult(this, procResult);

            //イベント
            OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
            {
                Type = procResult.IsSucceeded ? GraphStatusEventArgs.EventType.ProcessSuccess : GraphStatusEventArgs.EventType.ProcessFail,
                Args = nargs
            });
            
            //OutProcessなら実行する
            if (procResult.IsSucceeded && sender is OutProcessNode)
            {
                Logger.Debug($"GraphBase<{myName}>.Invoke().OutProcessNode.CallProcess()");
                await procResult.NextNode.CallProcess(nargs);
            }

            return procResult.ToInvokeResult();
        }
        
        public async Task<InvokeResult> InvokeWithoutArgs(bool callOutProcess, object[] parameters)
        {
            string myName = $"{GraphName}[{Id}]";

            Logger.Debug($"GraphBase<{myName}>.InvokeWithoutArgs()");

            var nargs = ProcessCallArgs.Fire(this);

            //イベント
            OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
            {
                Type = GraphStatusEventArgs.EventType.ProcessStart,
                Args = nargs
            });

            //Invoke
            Logger.Debug($"GraphBase<{myName}>.InvokeWithoutArgs().InvokeOnProcessCall");
            ProcessCallResult procResult = await OnProcessCall(nargs, parameters);
            Logger.Debug($"GraphBase<{myName}>.InvokeWithoutArgs().InvokedOnProcessCall<{procResult}>");

            //キャッシュする
            nargs.SetResult(this, procResult);

            //イベント
            OnStatusChanged?.Invoke(this, new GraphStatusEventArgs()
            {
                Type = procResult.IsSucceeded
                    ? GraphStatusEventArgs.EventType.ProcessSuccess
                    : GraphStatusEventArgs.EventType.ProcessFail,
                Args = nargs
            });

            //OutProcessなら実行する
            if (procResult.IsSucceeded && callOutProcess)
            {
                Logger.Debug($"GraphBase<{myName}>.InvokeWithoutArgs().OutProcessNode.CallProcess()");
                await procResult.NextNode.CallProcess(nargs);
            }

            return procResult.ToInvokeResult();
        }

        public abstract Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args,object[] parameters);

        /// <summary>
        /// ノードをグラフに追加する
        /// </summary>
        /// <param name="node">ノード</param>
        protected void AddNode(InItemNode node)
        {
            InItemNodes.Add(node);
        }


        /// <summary>
        /// ノードをグラフに追加する
        /// </summary>
        /// <param name="node">ノード</param>
        protected void AddNode(OutItemNode node)
        {
            OutItemNodes.Add(node);
        }


        /// <summary>
        /// ノードをグラフに追加する
        /// </summary>
        /// <param name="node">ノード</param>
        protected void AddNode(InProcessNode node)
        {
            InProcessNodes.Add(node);
        }


        /// <summary>
        /// ノードをグラフに追加する
        /// </summary>
        /// <param name="node">ノード</param>
        protected void AddNode(OutProcessNode node)
        {
            OutProcessNodes.Add(node);
        }

        /// <summary>
        /// このグラフはInProcessNodeと繋がれているかどうかを確認する
        /// </summary>
        /// <returns></returns>
        public bool IsConnectedInProcessNode()
        {
            if (InProcessNodes.Count > 0)
            {
                return Connector.TryGetAnotherNode(InProcessNodes[0], out var _);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 破棄する
        /// 所属しているノードも消す
        /// </summary>
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
}