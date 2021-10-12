using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Core.Variable;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Variable
{
    public abstract class VariableGraph : Core.Graph
    {

        private IVariableHolder _holder;

        protected IVariableHolder Holder
        {
            get => _holder;
            private set
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

        protected VariableGraph(NodeConnector connector, IVariableHolder holder) : base(connector)
        {
            _holder = holder;
        }

        protected abstract void OnVariableChanged();

        protected abstract void OnHolderChanged();
        
    }
}