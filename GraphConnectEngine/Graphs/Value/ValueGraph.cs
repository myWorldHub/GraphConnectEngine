using System.Threading.Tasks;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graphs.Value
{
    public class ValueGraph<T> : Core.Graph
    {
        public T Value;

        public ValueGraph(NodeConnector connector,T defaultValue) : base(connector)
        {
            Value = defaultValue;
            AddNode(new OutItemNode(this, typeof(T), 0,"Value"));
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            return Task.FromResult(ProcessCallResult.Success(new object[]{Value},OutProcessNode));
        }

        public override string GetGraphName() => "Value<" + typeof(T).Name + "> Graph";
    }
}