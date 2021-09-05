using System.Reflection;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class InstanceMethodGraph : GenerativeGraph
    {

        private InItemNode _objInItemNode;
        public InstanceMethodGraph(NodeConnector connector, MethodInfo methodInfo,bool streamItem = false) : base(connector, methodInfo, streamItem)
        {
            if (methodInfo.IsStatic || methodInfo.DeclaringType == null || methodInfo.IsGenericMethod || methodInfo.IsGenericMethodDefinition)
                return;

            _objInItemNode = new InItemNode(this,connector,methodInfo.DeclaringType);
        }

        protected override bool InvokeMethod(out object result)
        {
            object instance = null;
            if (!(_objInItemNode.Connector.TryGetAnotherNode(_objInItemNode, out OutItemNode orsv) &&
                  orsv.TryGetValue(out instance)))
            {
                result = null;
                return false; 
            }

            if (!TryGetParameterValues(out var param))
            {
                result = null;
                return false; 
            }

            result = MethodInfo.Invoke(instance, param);//TODO null check? try-catch
            return true;
        }


        public override string GetGraphName()
        {
            if (MethodInfo != null)
            {
                return "<" + MethodInfo.Name + "> Instance Method Graph";
            }

            return "Generative Instance Method Graph";
        }

        public override bool IsProcessNodeConnected()
        {
            return false;
        }
    }
}