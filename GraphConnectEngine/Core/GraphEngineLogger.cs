using System;

namespace GraphConnectEngine.Core
{
    public class GraphEngineLogger
    {
        private static Action<string> _writeLine;
        
        private const int LevelDebug = 0;
        private const int LevelError = 1;

        public static int LogLevel = -1;

        public static void SetLogMethod(Action<string> action)
        {
            _writeLine = action;
        }

        public static void Debug(string msg)
        {
            WriteLine(LevelDebug, msg);
        }

        public static void Error(string msg)
        {
            WriteLine(LevelError,msg);
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
            
            if (level == LevelDebug)
            {
                return time + "[DEBUG]";
            }
            else if (level == LevelError)
            {
                return time + "[Error]";
            }

            return time + "[Unknown]";
        }
    }
}