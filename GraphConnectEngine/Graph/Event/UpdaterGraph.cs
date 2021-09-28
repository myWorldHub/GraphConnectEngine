using System.Threading.Tasks;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Event
{
    public class UpdaterGraph : ProcessSenderGraph
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

        public UpdaterGraph(NodeConnector connector) : base(connector)
        {
            _time = 0;
        }

        public void ResetTime()
        {
            _time = _intervalTime;
        }

        public void Update(float deltaTime)
        {
            bool isZeroTime = _time >= 0 && _time - deltaTime < 0;
            _time -= deltaTime;
            
            if (IntervalType == Type.Update)
            {
                Fire();
            }
            else
            {
                if (_time <= 0)
                {
                    ResetTime();
                }
                
                if (isZeroTime)
                {
                    Fire();
                }
            }
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            return Task.FromResult(ProcessCallResult.Fail());
        }

        public override string GetGraphName() =>  "Updater Graph";
    }
}
