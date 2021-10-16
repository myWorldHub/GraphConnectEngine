using System;
using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine.Graphs.Operator
{
    /// <summary>
    /// 指定した型(T)にオブジェクトをキャストするグラフ
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CastGraph<T> : Graph
    {

        private Func<object, object> _lambda;
        
        public CastGraph(INodeConnector connector) : base(connector)
        {
            AddNode(new InItemNode(this,new ItemTypeResolver(typeof(object),"Object")));
            AddNode(new OutItemNode(this, new ItemTypeResolver(typeof(T), "Object"),0));

            var t = typeof(T);
            if (t == typeof(bool))
            {
                _lambda = o => Convert.ToBoolean(0);
            }
            else if (t == typeof(byte))
            {
                _lambda = o => Convert.ToByte(o);
            }
            else if (t == typeof(char))
            {
                _lambda = o => Convert.ToChar(o);
            }
            else if (t == typeof(decimal))
            {
                _lambda = o => Convert.ToDecimal(o);
            }
            else if (t == typeof(double))
            {
                _lambda = o => Convert.ToDouble(o);
            }
            else if (t == typeof(string))
            {
                _lambda = o => o.ToString();
            }
            else if (t == typeof(int))
            {
                _lambda = o => Convert.ToInt32(o);
            }
            else if (t == typeof(float))
            {
                _lambda = o => Convert.ToSingle(o);
            }
            else if (t == typeof(DateTime))
            {
                _lambda = o => Convert.ToDateTime(o);
            }
            else
            {
                //TODO 他のConvert対応のやつも追加する
                _lambda = o => (T) o;
            }
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            object value = parameters[0];

            // cast
            T a;
            bool isSuccess = false;
            
            try
            {
                var r = _lambda(value);
                if (r is T t)
                {
                    a = t;
                    isSuccess = true;
                }
                else
                {
                    a = default;
                }
            }
            catch (InvalidCastException)
            {
                a = default;
            }

            //失敗
            if (!isSuccess)
                return Task.FromResult(ProcessCallResult.Fail());

            return Task.FromResult(ProcessCallResult.Success(new object[] {a}, OutProcessNodes[0]));
        }

        public override string GraphName => "CastGraph<"+typeof(T).Name+">";
    }
}