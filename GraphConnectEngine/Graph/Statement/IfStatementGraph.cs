using GraphConnectEngine.Core;
using GraphConnectEngine.Node;
using System.Threading.Tasks;

namespace GraphConnectEngine.Graph.Statement
{
    public class IfStatementGraph : GraphBase
    {
        
        public IfStatementGraph(NodeConnector connector) : base(connector)
        {
            AddNode(new InItemNode(this,typeof(bool),"expression"));
            AddNode(new OutItemNode(this,typeof(bool),0,"expression"));

            AddNode(new OutProcessNode(this));
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            bool result = (bool)parameters[0];
            return Task.FromResult(ProcessCallResult.Success(
                new object[]
                {
                    result
                },
                result ? OutProcessNode : OutProcessNodes[1]));
        }

        public override string GetGraphName() => "If Statement Graph";
    }
}