using System;

namespace GraphConnectEngine.Node
{
    /// <summary>
    /// アイテムの型を解決するためのインターフェース
    /// 
    /// 実装すべき制約 :
    /// 型が変わる時は再接続する
    /// ItemTypeがvoidの場合、接続を許可しない
    /// </summary>
    public interface IItemTypeResolver : INodeStatusListener
    {
        /// <summary>
        /// 型が変わった時に呼ばれるリスナー
        /// </summary>
        event EventHandler<TypeChangeEventArgs> OnTypeChanged;
        
        /// <summary>
        /// 型を取得する
        /// </summary>
        /// <returns></returns>
        Type GetItemType();

        /// <summary>
        /// 型を設定する
        /// </summary>
        /// <param name="type">型</param>
        /// <param name="tryReconnect">再接続するかどうか</param>
        void SetItemType(Type type,bool tryReconnect = true);
    }
    
    /// <summary>
    /// デフォルト値取得用のデリゲート
    /// </summary>
    public delegate bool DefaultItemGetter(out object result);

    public class TypeChangeEventArgs : EventArgs
    {
        public Type From;
        public Type To;
    }
}