using System.Collections.Generic;
using System.Threading.Tasks;
using GraphConnectEngine.Node;

namespace GraphConnectEngine
{
    /// <summary>
    /// グラフのインターフェース
    /// </summary>
    public interface IGraph : IProcessCall
    {
        /// <summary>
        /// グラフを識別するための一意なID
        /// ProcessCallArgsなどで利用される
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// グラフ名を取得する
        /// </summary>
        /// <returns></returns>
        string GraphName { get; }
        
        /// <summary>
        /// ノードのコネクター
        /// </summary>
        INodeConnector Connector { get; }

        /// <summary>
        /// InProcessNodeのリスト
        /// </summary>
        IList<InProcessNode> InProcessNodes { get; }

        /// <summary>
        /// OutProcessNodeのリスト
        /// </summary>
        IList<OutProcessNode> OutProcessNodes { get; }

        /// <summary>
        /// InItemNodeのリスト
        /// </summary>
        IList<InItemNode> InItemNodes { get; }

        /// <summary>
        /// OutItemNodeのリスト
        /// </summary>
        IList<OutItemNode> OutItemNodes { get; }
    }
}