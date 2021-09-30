using System;
using System.Threading.Tasks;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Event
{
    public class DelayGraph : GraphBase
    {
        public DelayGraph(NodeConnector connector) : base(connector)
        {
            AddNode(new InItemNode(this,typeof(int),"Time"));
            AddNode(new OutItemNode(this, typeof(int), 0, "Time"));
        }

        public override async Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            int time = (int) parameters[0];
            
            await Task.Delay(TimeSpan.FromSeconds(time));
            
            return ProcessCallResult.Success(new object[] {time},OutProcessNode);
        }

        public override string GetGraphName()
        {
            return "Instantiate GameObject Graph";
        }
    }
}