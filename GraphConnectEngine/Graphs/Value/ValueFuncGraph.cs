using System;
using System.Threading.Tasks;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Value
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValueFuncGraph<T> : Graph
    {
        
        private Func<Task<ValueResult<T>>> _valueFunc;

        public ValueFuncGraph(NodeConnector connector, Func<Task<ValueResult<T>>> valueFunc) : base(connector)
        {
            _valueFunc = valueFunc;
            AddNode(new OutItemNode(this, typeof(T), 0,"Value"));
        }

        
        public override async Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            //実行
            var result = await _valueFunc();
            
            if (!result.IsSucceeded)
                return ProcessCallResult.Fail();

            return ProcessCallResult.Success(new object[]{result.Value},OutProcessNode);
        }

        public override string GetGraphName() => "ValueFunc<" + typeof(T).Name + "> Graph";
    }
}