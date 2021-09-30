using System.Threading.Tasks;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Event
{
    public class UpdaterGraph : GraphBase
    {

        public enum Type
        {
            Update,
            Time
        }

        private Type _intervalType = Type.Update;
        public Type IntervalType
        {
            get => _intervalType;
            set => _intervalType = value;
        }
        
        private float _intervalTime = 1;
        public float IntervalTime
        {
            get => _intervalTime;
            set
            {
                if(value > 0)
                    _intervalTime = value;
            }
        }

        private float _time;

        private IProcessSender _processSender;

        public UpdaterGraph(NodeConnector connector, IProcessSender processSender) : base(connector)
        {
            _time = 0;
            _processSender = processSender;
        }

        public void ResetTime()
        {
            _time = IntervalTime;
        }

        public async Task<bool> Update(float deltaTime)
        {
            bool isZeroTime = _time >= 0 && _time - deltaTime < 0;
            _time -= deltaTime;
            
            if (IntervalType == Type.Update)
            {
                await _processSender.Fire(OutProcessNode);
                return true;
            }
            else
            {
                if (_time <= 0)
                {
                    ResetTime();
                }
                
                if (isZeroTime)
                {
                    await _processSender.Fire(OutProcessNode);
                    return true;
                }
            }

            return false;
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            return Task.FromResult(ProcessCallResult.Fail());
        }

        public override string GetGraphName() =>  "Updater Graph";
    }
}
