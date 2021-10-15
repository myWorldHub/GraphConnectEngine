using System;

namespace GraphConnectEngine.Variable
{
    public interface IVariableHolderEvent
    {
        event EventHandler<VariableCreatedEventArgs> OnVariableCreated;

        event EventHandler<VariableUpdatedEventArgs> OnVariableUpdated;

        event EventHandler<VariableRemovedEventArgs> OnVariableRemoved;

        event EventHandler<EventArgs> OnDisposed;
    }
}