using System;
using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine.Graphs.Value
{
    /// <summary>
    /// OutItemNode[T]が1つあるグラフ
    /// コンストラクタでValueResult[T]を返す関数を渡し、実行時に利用される
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValueFuncGraph<T> : Graph
    {
        
        private Func<Task<ValueResult<T>>> _valueFunc;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="connector">コネクター</param>
        /// <param name="valueFunc">ValueResult[T]を返す関数</param>
        public ValueFuncGraph(INodeConnector connector, Func<Task<ValueResult<T>>> valueFunc) : base(connector)
        {
            _valueFunc = valueFunc;
            AddNode(new OutItemNode(this, new ItemTypeResolver(typeof(T), "Value"), 0));
        }

        
        public override async Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            //実行
            var result = await _valueFunc();
            
            if (!result.IsSucceeded)
                return ProcessCallResult.Fail();

            return ProcessCallResult.Success(new object[]{result.Value},OutProcessNodes[0]);
        }

        public override string GraphName => "ValueFunc<" + typeof(T).Name + "> Graph";
    }
}