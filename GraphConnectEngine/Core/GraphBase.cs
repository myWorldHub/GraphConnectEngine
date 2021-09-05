namespace GraphConnectEngine.Core
{
    public abstract class GraphBase
    {

        public readonly InProcessNode InProcessNode;
        public readonly OutProcessNode OutProcessNode;

        public GraphBase(NodeConnector connector)
        {
            InProcessNode = new InProcessNode(this, connector, OnProcessCall);
            OutProcessNode = new OutProcessNode(this, connector);
        }

        /// <summary>
        /// プロセスコールで呼ばれる
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public abstract bool OnProcessCall(ProcessCallArgs args);

        /// <summary>
        /// グラフ名を取得する
        /// </summary>
        /// <returns></returns>
        public abstract string GetGraphName();

        /// <summary>
        /// InProcessNodeが繋がれているかどうかを確認する
        /// </summary>
        /// <returns></returns>
        public virtual bool IsConnectedInProcessNode()
        {
            return InProcessNode.Connector.TryGetAnotherNode(InProcessNode, out GraphParentResolver resolver);
        }
    }
}