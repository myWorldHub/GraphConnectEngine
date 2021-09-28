using GraphConnectEngine.Core;
using GraphConnectEngine.Node;
using System.Threading.Tasks;

namespace GraphConnectEngine.Graph.Value
{
    public class ValueGraph<T> : GraphBase
    {
        public T Value;

        public ValueGraph(NodeConnector connector,T defaultValue) : base(connector)
        {
            Value = defaultValue;
            AddNode(new OutItemNode(this, typeof(T), 0,"Value"));
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            results = new object[] {Value};
            nextNode = OutProcessNode;
            return true;
        }

        public override string GetGraphName() => "Value<" + typeof(T).Name + "> Graph";
    }
}