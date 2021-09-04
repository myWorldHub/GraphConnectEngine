using System.Collections.Generic;
using System.Reflection;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class DirectMethodGraph : GraphBase
    {

        private MethodInfo _methodInfo;

        private readonly List<InItemNode> _inItemNodes = new List<InItemNode>();
        private readonly List<OutItemNode> _outItemNodes = new List<OutItemNode>();

        public DirectMethodGraph(NodeConnector connector, MethodInfo methodInfo,bool streamItem = false)
        {
            //TODO 生成
        }
        
        public override string GetGraphName()
        {
            if (_methodInfo != null)
            {
                return "<" + _methodInfo.Name + "> Graph";
            }
            return "Direct Method Graph";
        }
    }
}