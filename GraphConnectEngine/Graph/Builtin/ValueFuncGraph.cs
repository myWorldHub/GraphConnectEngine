using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Builtin
{
    public class ValueFuncGraph<T> : GraphBase
    {
        public delegate bool ValueFunc(out T result);
        
        private ValueFunc _valueFunc;

        public ValueFuncGraph(NodeConnector connector, ValueFunc valueFunc) : base(connector)
        {
            _valueFunc = valueFunc;
            AddItemNode(new OutItemNode(this, typeof(T), 0));
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!_valueFunc(out T result))
            {
                results = null;
                nextNode = null;
                return false;
            }

            results = new object[] {result};
            nextNode = OutProcessNode;
            return true;
        }

        public override string GetGraphName()
        {
            return typeof(T).Name + " Graph";
        }
    }
}