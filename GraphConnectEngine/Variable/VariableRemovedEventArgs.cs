using System;

namespace GraphConnectEngine.Variable
{
    public class VariableRemovedEventArgs : EventArgs
    {
        public VariableRemovedEventArgs(string name)
        {
            Name = name;
        }

        public readonly string Name;
    }
}