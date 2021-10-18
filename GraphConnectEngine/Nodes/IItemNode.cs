namespace GraphConnectEngine.Nodes
{
    public interface IItemNode
    {
        /// <summary>
        /// 型解決用
        /// </summary>
        IItemTypeResolver TypeResolver { get; }
    }
}