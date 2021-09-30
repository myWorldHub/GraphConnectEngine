using System;

namespace GraphConnectEngine.Core
{
    public class Logger
    {
        private static Action<string> _writeLine;
        
        private const int LevelDebug = 0;
        private const int LevelError = 1;

        public static int LogLevel = 9999;

        public static void SetLogMethod(Action<string> action)
        {
            _writeLine = action;
        }

        public static void Debug(string msg)
        {
            if(LogLevel <= LevelDebug)
                WriteLine(LevelDebug, msg);
        }

        public static void Error(string msg)
        {
            if (LogLevel <= LevelError)
                WriteLine(LevelError,msg);
        }

        public static void WriteLine(int level,string message)
        {
            if (_writeLine != null)
            {
                _writeLine(Prefix(level) + message);
            }
        }

        public static string Prefix(int level)
        {
            var time = "[" + DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds + "]";
            
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