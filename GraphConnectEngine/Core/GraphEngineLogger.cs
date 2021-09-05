using System;

namespace GraphConnectEngine.Core
{
    public class GraphEngineLogger
    {
        private static Action<string> _writeLine;

        public const int Debug = 0;
        public const int Error = 1;

        public static int LogLevel = Debug;

        public static void SetLogMethod(Action<string> action)
        {
            _writeLine = action;
        }

        public static void WriteLine(int level,string message)
        {
            if (level >= LogLevel && _writeLine != null)
            {
                _writeLine(Prefix(level) + message);
            }
        }

        public static string Prefix(int level)
        {
            var time = "[" + DateTime.Now.Millisecond.ToString() + "]";
            
            if (level == Debug)
            {
                return time + "[DEBUG]";
            }
            else if (level == Error)
            {
                return time + "[Error]";
            }

            return time + "[Unknown]";
        }
    }
}