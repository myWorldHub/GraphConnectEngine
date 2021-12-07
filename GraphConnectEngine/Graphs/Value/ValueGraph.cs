using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine.Graphs.Value
{
    /// <summary>
    /// OutItemNode[T]が1つあるグラフ
    /// コンストラクタで値のデフォルト値を設定できる。
    /// 実行時はValueをOutItemNode[0]に渡す
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValueGraph<T> : Graph
    {
        /// <summary>
        /// 実行時に返される値
        /// </summary>
        public T Value;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="defaultValue">Tのデフォルト値</param>
        public ValueGraph(T defaultValue) : base()
        {
            Value = defaultValue;
            AddNode(new OutItemNode(this, new ItemTypeResolver(typeof(T), "Value"),0));
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessData args, object[] parameters)
        {
            return Task.FromResult(ProcessCallResult.Success(new object[]{Value},OutProcessNodes[0]));
        }

        public override string GraphName => "Value<" + typeof(T).Name + ">";
    }
}
