using System;
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
                if (_holder != null)
                {
                    _holder.OnDisposed -= OnHolderDisposed;
                    _holder.OnVariableRemoved -= _OnVariableRemoved;
                }
                
                if (value != null)
                {
                    value.OnDisposed += OnHolderDisposed;
                    value.OnVariableRemoved += _OnVariableRemoved;
                }

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
            _holder = holder;
        }

        protected abstract void OnVariableChanged();

        protected abstract void OnHolderChanged();

        protected abstract void OnVariableRemoved();

        private void OnHolderDisposed(object sender, EventArgs args)
        {
            Holder = null;
        }

        private void _OnVariableRemoved(object sender, VariableRemovedEventArgs args)
        {
            if (args.Name == VariableName)
            {
                OnVariableRemoved();
            }
        }
    }
}