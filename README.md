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

## グラフの定義の例

### グラフの実行を開始するグラフ
https://github.com/nananapo/GraphConnectEngine/blob/master/GraphConnectEngine/Graphs/Event/UpdaterGraph.cs

Update関数を呼ぶことでProcessNode[0]につながれているグラフが呼ばれます。

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
