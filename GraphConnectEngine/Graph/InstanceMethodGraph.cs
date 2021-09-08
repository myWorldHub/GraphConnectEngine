using System.Reflection;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class InstanceMethodGraph : GenerativeGraph
    {

        private InItemNode _objInItemNode;
        public InstanceMethodGraph(NodeConnector connector, MethodInfo methodInfo) : base(connector, methodInfo)
        {
            if (methodInfo.IsStatic || methodInfo.DeclaringType == null || methodInfo.IsGenericMethod || methodInfo.IsGenericMethodDefinition)
                return;

            _objInItemNode = new InItemNode(this,connector,methodInfo.DeclaringType);
        }

        protected override bool InvokeMethod(ProcessCallArgs args,object[] param,out object result)
        {
            if (!_objInItemNode.GetItemFromConnectedNode(args, out object instance) || instance.GetType() != MethodInfo.DeclaringType)
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