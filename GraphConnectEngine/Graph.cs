using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphConnectEngine.Node;

namespace GraphConnectEngine
{
    /// <summary>
    /// グラフ
    ///
    /// フローベースプログラミングの実行の一単位となるもの
    /// グラフにはノードが存在していて、違うグラフとノードを繋いで値を加工する
    ///
    /// TODO InProcessNodesとかをプロパティにする
    /// </summary>
    public abstract class Graph : IProcessCall,IDisposable
    {
        /// <summary>
        /// ノードのコネクター
        /// </summary>

        public readonly NodeConnector Connector;

        /// <summary>
        /// InProcessNodeのリスト
        /// </summary>
        public readonly List<InProcessNode> InProcessNodes = new List<InProcessNode>();
        
        /// <summary>
        /// OutProcessNodeのリスト
        /// </summary>
        public readonly List<OutProcessNode> OutProcessNodes = new List<OutProcessNode>();

        /// <summary>
        /// InItemNodeのリスト
        /// </summary>
        public readonly List<InItemNode> InItemNodes = new List<InItemNode>();

        /// <summary>
        /// OutItemNodeのリスト
        /// </summary>
        public readonly List<OutItemNode> OutItemNodes = new List<OutItemNode>();

        /// <summary>
        /// InProcessNode[0]
        /// </summary>
        public InProcessNode InProcessNode => InProcessNodes[0];

        /// <summary>
        /// OutProcessNode[0]
        /// </summary>
        public OutProcessNode OutProcessNode => OutProcessNodes[0];

        /// <summary>
        /// グラフを識別するための一意なID
        /// ProcessCallArgsなどで利用される
        /// </summary>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// 実行ステータスのリスナ
        /// </summary>
        public event EventHandler<GraphStatusEventArgs> OnStatusChanged;

        /// <summary>
        /// コンストラクタ
        /// IdはコンストラクタでHashCodeで割り当てられる
        ///
        /// TODO IDを引数に入れる
        /// </summary>
        /// <param name="connector">コネクター</param>
        /// <param name="id">識別用のID(全てのグラフのインスタンスでユニークである必要がある)</param>
        /// <param name="enableInProcess">InProcessNodeを自動生成する</param>
        /// <param name="enableOutProcess">OutProcessNodeを自動生成する</param>
        public Graph(NodeConnector connector,bool enableInProcess = true,bool enableOutProcess = true)
        {
            Id = GetHashCode().ToString();
            Connector = connector;

            if(enableInProcess)
                AddNode(new InProcessNode(this));
            
            if(enableOutProcess)
                AddNode(new OutProcessNode(this));
        }

        public async Task<InvokeResult> Invoke(object sender,ProcessCallArgs args)
        {
            string myName = $"{GetGraphName()}[{Id}]";

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
            string myName = $"{GetGraphName()}[{Id}]";

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
        /// グラフ名を取得する
        /// </summary>
        /// <returns></returns>
        public abstract string GetGraphName();

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
            return InProcessNode.Connector.TryGetAnotherNode(InProcessNode, out var _);
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