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

            string myHash = GetHashCode().ToString();
            string myName = $"{GetGraphName()}[{myHash}]";
            
            GraphEngineLogger.Debug($"{myName} is Called with\n{args}");
            
            if(!args.TryAdd(myHash,true,out var nargs))
            {
                return false;
            }

            GraphEngineLogger.Debug($"{myName} Invoke OnProcessCall in GraphBase with\n{nargs}");
            
            bool result = OnProcessCall(nargs,out var nextNode);

            GraphEngineLogger.Debug($"{myName} Invoked OnProcessCall with result {result}");
            
            if (result)
            {
                nextNode?.CallProcess(args);
            }
            
            return result;
        }

        /// <summary>
        /// ProcessCallで呼ばれる
        /// 実装では必ずOutItemをキャッシュさせる
        /// </summary>
        /// <param name="args"></param>
        /// <param name="nextNode"></param>
        /// <returns></returns>
        protected abstract bool OnProcessCall(ProcessCallArgs args,out OutProcessNode nextNode);

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