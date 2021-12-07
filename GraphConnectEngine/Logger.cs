using GraphConnectEngine.Nodes;
using System;

namespace GraphConnectEngine
{
    /// <summary>
    /// ログ出力のためのクラス
    ///
    /// TODO ILogger作る
    /// </summary>
    public class Logger
    {
        private static Action<string> _writeLine;
        
        public const int LevelDebug = 0;
        
        public const int LevelError = 1;

        /// <summary>
        /// ログレベル
        /// </summary>
        public static int LogLevel = 9999;

        /// <summary>
        /// ログ出力に使う関数を設定する
        /// </summary>
        /// <param name="action"></param>
        public static void SetLogMethod(Action<string> action)
        {
            _writeLine = action;
        }

        /// <summary>
        /// デバッグ
        /// </summary>
        /// <param name="msg"></param>
        public static void Debug(string msg)
        {
            if(LogLevel <= LevelDebug)
                WriteLine(LevelDebug, msg);
        }

        /// <summary>
        /// エラー
        /// </summary>
        /// <param name="msg"></param>
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

        internal static string Prefix(int level)
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



        /// <summary>
        /// ノードの情報をLoggerにダンプする
        /// </summary>
        /// <param name="node"></param>
        public static void DumpNode(INode node)
        {
            if (LogLevel > LevelDebug)
                return;
            
            Debug($"Dump of Node:{node}");
            Debug($"Type : {node.GetType().FullName}");
            Debug($"Graph : {node.Graph}");
            if (node is IItemNode iin)
            {
                Debug($"ItemType : ${iin.TypeResolver.GetItemType().FullName}");
            }
        }
    }
}
