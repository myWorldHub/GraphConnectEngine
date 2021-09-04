using System.Reflection;
using GraphConnectEngine.Core;

namespace GraphConnectEngine.Graph
{
    public class StaticMethodGraph : GenerativeGraph
    {

        public StaticMethodGraph(NodeConnector connector, MethodInfo methodInfo,bool streamItem = false) : base(connector,methodInfo,streamItem)
        {
            if (methodInfo == null || !methodInfo.IsStatic || 
                !methodInfo.IsPublic || methodInfo.IsGenericMethod || methodInfo.IsGenericMethodDefinition)
                return;//TODO Exception
        }

        protected override object InvokeMethod()
        {
            if (!TryGetParameterValues(out var param))
            {
                return null;//TODO 失敗
            }

            var result = MethodInfo.Invoke(null, param); //TODO null check? try-catch
            return result; 
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
