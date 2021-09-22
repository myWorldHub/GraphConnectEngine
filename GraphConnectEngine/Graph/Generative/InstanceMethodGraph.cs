using System.Reflection;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Generative
{
    public class InstanceMethodGraph : GenerativeGraph
    {
        public InstanceMethodGraph(NodeConnector connector, MethodInfo methodInfo) : base(connector, methodInfo)
        {
            if (methodInfo.IsStatic || methodInfo.DeclaringType == null || methodInfo.IsGenericMethod || methodInfo.IsGenericMethodDefinition)
                return;

            AddNode(new InItemNode(this,methodInfo.DeclaringType,"Object"));
        }

        protected override bool InvokeMethod(ProcessCallArgs args,object[] param,out object result)
        {
            
            if (!InItemNodes[InItemNodes.Count-1].GetItemFromConnectedNode(args, out object instance) || instance.GetType() != MethodInfo.DeclaringType)
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