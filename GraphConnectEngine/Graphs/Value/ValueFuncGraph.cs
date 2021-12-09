using System;
using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine.Graphs.Value
{
    /// <summary>
    /// OutItemNode[T]が1つあるグラフ
    /// ValueResult[T]を返す関数を渡すと、実行時に利用される
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValueFuncGraph<T> : Graph
    {
        
        private Func<Task<ValueResult<T>>> _valueFunc;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public ValueFuncGraph(string id) : this(id, null) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="func"></param>
        public ValueFuncGraph(string id, Func<Task<ValueResult<T>>> func) : base(id)
        {
            this._valueFunc = func;
            AddNode(new OutItemNode(this, new ItemTypeResolver(typeof(T), "Value"), 0));
        }

        /// <summary>
        /// 値を受け取る関数を設定する
        /// </summary>
        /// <param name="valueFunc"></param>
        public void SetValueFunction(Func<Task<ValueResult<T>>> valueFunc)
        {
            this._valueFunc = valueFunc;
        }

        
        public override async Task<ProcessCallResult> OnProcessCall(ProcessData args, object[] parameters)
        {
            //実行
            var result = await _valueFunc();
            
            if (!result.IsSucceeded)
                return ProcessCallResult.Fail();

            return ProcessCallResult.Success(new object[]{result.Value},OutProcessNodes[0]);
        }

        public override string GraphName => "ValueFunc<" + typeof(T).Name + ">";
    }
}
