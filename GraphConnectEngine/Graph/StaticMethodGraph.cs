using System.Reflection;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class StaticMethodGraph : GenerativeGraph
    {

        public StaticMethodGraph(NodeConnector connector, MethodInfo methodInfo) : base(connector,methodInfo)
        {
            if (!methodInfo.IsStatic || methodInfo.IsGenericMethod || methodInfo.IsGenericMethodDefinition)
                return;//TODO Exception
        }

        protected override bool InvokeMethod(ProcessCallArgs args,object[] param,out object result)
        {
            result = MethodInfo.Invoke(null, param); //TODO null check? try-catch
            return true; 
        }

        public override string GetGraphName()
        {
            if (MethodInfo != null)
            {
                return "<" + MethodInfo.Name + "> Static Method Graph";
            }
            return "Generative Static Method Graph";
        }
    }
}
