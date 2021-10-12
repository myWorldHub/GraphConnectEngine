using System;

namespace GraphConnectEngine.Core.Variable
{
    public interface IVariableHolderEvent
    {
        event EventHandler<VariableCreatedEventArgs> OnVariableCreated;

        event EventHandler<VariableUpdatedEventArgs> OnVariableUpdated;

        event EventHandler<VariableRemovedEventArgs> OnVariableRemoved;

        event EventHandler<EventArgs> OnDisposed;
    }
}