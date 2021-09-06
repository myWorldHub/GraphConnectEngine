using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
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
                OutProcessNode.CallProcess(ProcessCallArgs.Fire(GetHashCode()));
            }
            else
            {
                if (_time <= 0)
                {
                    ResetTime();
                }
                
                if (isZeroTime)
                {
                    OutProcessNode.CallProcess(ProcessCallArgs.Fire(GetHashCode()));
                }
            }
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out OutProcessNode nextNode)
        {
            nextNode = null;
            return false;
        }

        public override string GetGraphName()
        {
            return "Updater Graph";
        }
        
        public override bool IsConnectedInProcessNode()
        {
            return false;
        }
    }
}
