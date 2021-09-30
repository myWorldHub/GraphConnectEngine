using Cysharp.Threading.Tasks;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Core
{
    public interface IProcessCall
    {
        UniTask<ProcessCallResult> OnProcessCall(ProcessCallArgs args,object[] parameters);
    }

    public class ProcessCallResult
    {
        public bool IsSucceeded;
        public object[] Results;
        public OutProcessNode NextNode;

        public static ProcessCallResult Fail()
        {
            return new ProcessCallResult()
            {
                IsSucceeded = false
            };
        }

        public static ProcessCallResult Success(object[] results,OutProcessNode nextNode)
        {
            return new ProcessCallResult()
            {
                IsSucceeded = true,
                Results = results,
                NextNode = nextNode
            };
        }

        public GraphBase.InvokeResult ToInvokeResult()
        {
            return (GraphBase.InvokeResult) this;
        }

        public static explicit operator GraphBase.InvokeResult(ProcessCallResult result)
        {
            return GraphBase.InvokeResult.Create(result.IsSucceeded,result.Results);
        }
        
        public override string ToString()
        {
            var a = IsSucceeded ? "Success" : "Fail";
            return $"ProcessCallResult<{a}> => Next[{NextNode}]";
        }
    }
}