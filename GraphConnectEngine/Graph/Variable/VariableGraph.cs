using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Variable
{
    public abstract class VariableGraph : GraphBase
    {

        private VariableHolder _holder;

        public VariableHolder Holder
        {
            get => _holder;
            set
            {
                _holder = value;
                OnHolderChanged();
            }
        }

        private string _variableName = "";

        public string VariableName
        {
            get => _variableName;
            set
            {
                _variableName = value;
                OnVariableChanged();
            }
        }

        public VariableGraph(NodeConnector connector, VariableHolder holder) : base(connector)
        {
            Holder = holder;
        }

        protected abstract void OnVariableChanged();

        protected abstract void OnHolderChanged();
    }
}