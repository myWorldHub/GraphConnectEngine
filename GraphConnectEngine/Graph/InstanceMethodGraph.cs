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

        protected override bool InvokeMethod(ProcessCallArgs args,out object result,bool goBack)
        {
            object instance = null;
            if (!(_objInItemNode.Connector.TryGetAnotherNode(_objInItemNode, out OutItemNode orsv) &&
                  orsv.TryGetValue(args,out instance, goBack)))
            {
                result = null;
                return false; 
            }

            if (!TryGetParameterValues(args,out var param, goBack))
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
    }
}