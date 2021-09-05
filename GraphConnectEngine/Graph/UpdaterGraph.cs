using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class UpdaterGraph : GraphBase
    {
        
        public readonly OutProcessNode OutProcessNode;

        public enum Type
        {
            EveryFixedUpdate,
            Time
        }

        private Type _intervalType = Type.EveryFixedUpdate;
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

        private float _time = 0;

        public UpdaterGraph(NodeConnector connector)
        {
            OutProcessNode = new OutProcessNode(this,connector);
        }

        public void ResetTime()
        {
            _time = _intervalTime;
        }

        public void OnFiexedUpdate(float deltaTime)
        {
            bool isZeroTime = _time >= 0 && _time - deltaTime < 0;
            _time -= deltaTime;
            
            if (IntervalType == Type.EveryFixedUpdate)
            {
                OutProcessNode.CallProcess(new ProcessCallArgs(GetHashCode().ToString()));
            }
            else
            {
                if (_time <= 0)
                {
                    ResetTime();
                }
                
                if (isZeroTime)
                {
                    OutProcessNode.CallProcess(new ProcessCallArgs(GetHashCode().ToString()));
                }
            }
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
