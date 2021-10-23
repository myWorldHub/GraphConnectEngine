using System;

namespace GraphConnectEngine.Variable
{
    /// <summary>
    /// VariableHolderが実装すべきイベントのインターフェース
    /// </summary>
    public interface IVariableHolderEvent : IDisposable
    {
        /// <summary>
        /// 変数が作成された時に呼ばれるイベント
        /// </summary>
        event EventHandler<VariableCreatedEventArgs> OnVariableCreated;

        /// <summary>
        /// 変数が更新された時に呼ばれるイベント
        /// </summary>
        event EventHandler<VariableUpdatedEventArgs> OnVariableUpdated;

        /// <summary>
        /// 変数が削除された時に呼ばれるイベント
        /// </summary>
        event EventHandler<VariableRemovedEventArgs> OnVariableRemoved;

        event EventHandler<EventArgs> OnDisposed;
    }

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

    public class VariableRemovedEventArgs : EventArgs
    {
        public VariableRemovedEventArgs(string name)
        {
            Name = name;
        }

        public readonly string Name;
    }

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