using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Builtin
{
    public abstract class ValueGraph<T> : GraphBase
    {
        public T Value;

        public ValueGraph(NodeConnector connector,T defaultValue) : base(connector)
        {
            Value = defaultValue;
            AddItemNode(new OutItemNode(this, typeof(T), 0));
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            results = new object[] {Value};
            nextNode = OutProcessNode;
            return true;
        }

        public override string GetGraphName()
        {
            return typeof(T).Name + " Graph";
        }
    }
}