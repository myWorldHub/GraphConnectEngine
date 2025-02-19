﻿using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine.Graphs.Event
{
    /// <summary>
    /// プロセスを遅延させるグラフ
    /// </summary>
    public class DelayGraph : Graph
    {
        public DelayGraph(string id) : base(id)
        {
            IItemTypeResolver resolver = new ItemTypeResolver(typeof(int), "Time");
            AddNode(new InItemNode(this, resolver));
            AddNode(new OutItemNode(this, resolver,0));
        }

        public override async Task<ProcessCallResult> OnProcessCall(ProcessData args, object[] parameters)
        {
            int time = (int) parameters[0];
            await Task.Delay(time * 1000);
            return ProcessCallResult.Success(new object[] {time},OutProcessNodes[0]);
        }

        public override string GraphName =>  "Delay";
    }
}
