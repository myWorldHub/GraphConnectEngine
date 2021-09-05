namespace GraphConnectEngine.Core
{
    public abstract class GraphBase
    {

        public readonly InProcessNode InProcessNode;
        public readonly OutProcessNode OutProcessNode;

        public GraphBase(NodeConnector connector)
        {
            InProcessNode = new InProcessNode(this, connector, _OnProcessCall);
            OutProcessNode = new OutProcessNode(this, connector);
        }

        private bool _OnProcessCall(ProcessCallArgs args)
        {
            ProcessCallArgs nargs = args.Add(GetHashCode().ToString());
            
            bool result = OnProcessCall(nargs);
            if (result)
            {
                GetNextNode(args).CallProcess(args);
            }
            
            return result;
        }

        /// <summary>
        /// ProcessCallで呼ばれる
        /// 実装では必ずOutItemをキャッシュさせる
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        protected abstract bool OnProcessCall(ProcessCallArgs args);

        /// <summary>
        /// ProcessCallが成功した時に、次に呼ぶOutProcessNodeを取得する
        /// TODO ifGraphで使う
        /// </summary>
        /// <returns></returns>
        public virtual OutProcessNode GetNextNode(ProcessCallArgs args)
        {
            return OutProcessNode;
        }

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