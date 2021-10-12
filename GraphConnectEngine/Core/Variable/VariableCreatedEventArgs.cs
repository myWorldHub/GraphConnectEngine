using System;

namespace GraphConnectEngine.Core.Variable
{
    public class VariableCreatedEventArgs : EventArgs
    {

        public VariableCreatedEventArgs(string name, Type type)
        {
            Name = name;
            Type = type;
        }

        public readonly string Name;
        public readonly Type Type;
    }
}