using System;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// 型が変わる時は再接続される
    /// ItemTypeがvoidの場合、接続を許可しない
    /// </summary>
    public interface IItemTypeResolver : INodeStatusListener
    {
        Type GetItemType();

        void SetItemType(Type type,bool tryReconnect = true);
    }
    
    public delegate bool DefaultItemGetter(out object result);

    public class TypeChangeEventArgs : EventArgs
    {
        public Type From;
        public Type To;
    }
}