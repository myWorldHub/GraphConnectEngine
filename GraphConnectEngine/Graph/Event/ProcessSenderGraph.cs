using System.Threading.Tasks;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Event
{
    public abstract class ProcessSenderGraph : GraphBase
    {
        
        //TODO 実行制限 : キャッシュの処理を加えるまで
        //TODO 1秒ごと,1秒後に
        private bool _isProcessing = false;
        
        public ProcessSenderGraph(NodeConnector connector) : base(connector)
        {
        }

        protected virtual async Task Fire()
        {
            if (_isProcessing)
                return;

            Logger.Debug("---------------------------------------------------------------------");
            
            _isProcessing = true;
            await OutProcessNode.CallProcess(ProcessCallArgs.Fire(GetHashCode()));
            _isProcessing = false;
        }

        public override bool IsConnectedInProcessNode()
        {
            return false;
        }
    }
}