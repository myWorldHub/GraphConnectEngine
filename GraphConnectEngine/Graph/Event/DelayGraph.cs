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
            
            Logger.Debug(time*1000+"mil秒待つ");
            await Task.Delay(time * 1000);
            Logger.Debug(time + "秒待った");
            
            return ProcessCallResult.Success(new object[] {time},OutProcessNode);
        }

        public override string GetGraphName()
        {
            return "Delay Graph";
        }
    }
}