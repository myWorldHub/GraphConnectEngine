using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// InProcessNodeを呼んでプロセスを伝播するノード
    ///
    /// CallProcessでプロセスを呼ぶ
    /// InProcessNodeとは複数繋ぐことができるが、実行順は保証されない
    /// </summary>
    public class OutProcessNode : Node
    {

        public OutProcessNode(IGraph parentGraph)
        {
            Graph = parentGraph;
        }

        /// <summary>
        /// InProcessNodeのOnCalledを呼び、プロセスを伝播する
        /// </summary>
        /// <param name="args">プロセス情報</param>
        /// <returns></returns>
        public async Task<bool> CallProcess(ProcessCallArgs args)
        {
            Logger.Debug($"OutProcessNode.CallProcess() Start > {Graph.Id} > {args}");

            if (!Graph.Connector.TryGetOtherNodes(this, out InProcessNode[] resolvers))
            {
                Logger.Debug($"OutProcessNode.CallProcess().Success > No node is Connected");
                return true;
            }
            
            for (int i = 0; i < resolvers.Length; i++)
            {
                var inProcessNode = resolvers[i];
                if (args.TryAdd(Graph.Id + "_" + i, true, out var nargs))
                {
                    Logger.Debug($"OutProcessNode.CallProcess().Call InProcessNode {i} / {resolvers.Length}");
                    await inProcessNode.OnCalled(this,nargs);
                }
            }

            return true;
        }
        
        public override bool IsAttachableNodeType(Type type)
        {
            var dt = typeof(InProcessNode);
            return !(type != dt && !type.IsSubclassOf(dt));
        }

        public override bool CanAttach(INode anotherNode)
        {
            if (anotherNode is InProcessNode outNode)
            {
                return true;
            }
            return false;
        }
    }
}