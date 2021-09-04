using System.Reflection;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class InstanceMethodGraph : GenerativeGraph
    {

        private InItemNode _objInItemNode;
        public InstanceMethodGraph(NodeConnector connector, MethodInfo methodInfo,bool streamItem = false) : base(connector, methodInfo, streamItem)
        {
            if (methodInfo == null || methodInfo.IsStatic || 
                !methodInfo.IsPublic || methodInfo.DeclaringType == null || methodInfo.IsGenericMethod || 
                methodInfo.IsGenericMethodDefinition)
                return;

            _objInItemNode = new InItemNode(this,connector,methodInfo.DeclaringType);
        }

        protected override object InvokeMethod()
        {
            object instance = null;
            if (!(_objInItemNode.Connector.TryGetAnotherNode(_objInItemNode, out OutItemNode orsv) &&
                  orsv.TryGetValue(out instance)))
            {
                return null; //TODO 失敗
            }

            if (!TryGetParameterValues(out var param))
            {
                return null; //TODO 失敗
            }

            var result = MethodInfo.Invoke(instance, param);//TODO null check? try-catch
            return result;
        }


        public override string GetGraphName()
        {
            if (MethodInfo != null)
            {
                return "<" + MethodInfo.Name + "> Instance Method Graph";
            }

            return "Generative Instance Method Graph";
        }
    }
}