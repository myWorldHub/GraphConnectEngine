# GraphConnectEngine

![image](https://user-images.githubusercontent.com/26675945/157771298-544ff4a7-9d24-4a81-8d5a-753fbdc6c2b0.png)

* ドキュメント
https://nana.oekaki.chat/GraphConnectEngine/namespaces.html

GraphConnectEngineは、C#でノードベースプログラミングを実装するために使えるライブラリです。

## 定義

グラフ(Graph) : プログラムの処理の一単位

ノード(Node) : グラフ同士で入出力、実行順を制御するための接続点

アイテム(Item) : グラフの入出力の値のこと。ノードを使ってグラフからグラフへ渡される

プロセス(Process) : グラフの実行を管理するためのアイテムのこと。これがグラフに渡るとそのグラフが実行される

## 例

### 自由な値を一つ受け取って、それを出力するグラフ

```csharp
using System;
using System.Threading.Tasks;
using GraphConnectEngine;
using GraphConnectEngine.Nodes;

internal class TestGraph : Graph
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id">ユニークなID</param>
    public TestGraph(string id) : base(id, true, true) // プロセスを受け取るノードとプロセスを吐き出すノードを自動で作成するのでtrue,true
    {
        // アイテムを受け取るノードを追加する
        AddNode(new InItemNode(this, new ItemTypeResolver(typeof(object), "InputObject")));
    }

    /// <summary>
    /// グラフ名
    /// </summary>
    public override string GraphName => "TestGraph";

    /// <summary>
    /// プロセスが渡ってきたら呼ばれる関数
    /// </summary>
    /// <param name="proc">プロセスの情報</param>
    /// <param name="parameters">他のグラフから受け取ったItemが入った配列</param>
    /// <returns>実行結果</returns>
    public override Task<ProcessCallResult> OnProcessCall(ProcessData proc, object[] parameters)
    {
        var text = parameters[0].ToString();

        Console.WriteLine(text);

        // 実行成功で、アイテムを何も出力しないで、プロセスを吐き出すノードをOutProcessNodes[0]に指定したものを返す
        return Task.FromResult(ProcessCallResult.Success(Array.Empty<object>(), OutProcessNodes[0]));
    }
}
```

### グラフの実行を開始するグラフ
https://github.com/nananapo/GraphConnectEngine/blob/master/GraphConnectEngine/Graphs/Event/UpdaterGraph.cs

Update関数を呼ぶことでProcessNode[0]につながれているグラフが呼ばれます。

### グラフを作成してノードを繋ぐ

```csharp
class ProcessSender : IProcessSender
{
    private readonly INodeConnector Connector;

    public ProcessSender(INodeConnector connector)
    {
        Connector = connector;
    }

    public Task Fire(object sender, IGraph graph, object[] parameters)
    {
        graph.InvokeWithoutCheck(ProcessData.Fire(graph, Connector), true,parameters);
        return Task.CompletedTask;
    }
}
```

```csharp
// グラフの接続を管理するもの
var connector = new NodeConnector();

// GraphConnectEngine.Graphs.Valueにある、値をOutItemNodes[0]に出力するグラフ
var textGraph = new ValueGraph<string>("textGraphId","Hello");
// 上の例で作成したグラフ
var testGraph = new TestGraph("testGraphId");
// GraphConnectEngine.Graphs.Eventにある、実行を開始するグラフ
var updater = new UpdaterGraph("updater", new ProcessSender(connector));

// textGraphの出力ノードと、testGraphの入力ノードを繋ぐ
connector.ConnectNode(textGraph.OutItemNodes[0], testGraph.InItemNodes[0]);
// updaterのプロセスを吐くノードと、testGraphのプロセスを受け取るノードを繋ぐ
connector.ConnectNode(updater.OutProcessNodes[0], testGraph.InProcessNodes[0]);

// updaterから実行を開始する
await updater.Update(DateTime.Now,0);
```


