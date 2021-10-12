using System;

namespace GraphConnectEngine.Core.Variable
{
    public class VariableUpdatedEventArgs : EventArgs
    {

        public VariableUpdatedEventArgs(string name, Type type, Object value)
        {
            Name = name;
            Type = type;
            Value = value;
        }

        public readonly string Name;
        public readonly Type Type;
        public readonly Object Value;
    }
}