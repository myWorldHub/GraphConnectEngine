namespace GraphConnectEngine.Core
{
    public abstract class GraphBase
    {
        public abstract string GetGraphName();

        /// <summary>
        /// InProcessNodeが存在し、繋がれているかどうかを確認する
        /// TODO 選択的にする
        /// </summary>
        /// <returns></returns>
        public abstract bool IsConnectedInProcessNode();
    }
}