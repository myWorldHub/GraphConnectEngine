using System;

namespace GraphConnectEngine
{
    public class GraphStatusEventArgs : EventArgs
    {
        public enum EventType
        {
            InvokeCalled,
            ParamError,
            ProcessStart,
            ProcessSuccess,
            ProcessFail,
            CacheUsed,
            CacheError,
            LoopDetected,
            UnknownError
        }

        public EventType Type;
        public ProcessCallArgs Args;
    }
}