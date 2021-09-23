using System;
using GraphConnectEngine.Core;
using GraphConnectEngine.Node;

namespace GraphConnectEngine.Graph.Operator
{
    public class CastGraph<T> : GraphBase where T : struct 
    {
        public CastGraph(NodeConnector connector) : base(connector)
        {
            AddNode(new InItemNode(this,typeof(object),"Object"));
            AddNode(new OutItemNode(this,typeof(T),0,"Object"));
        }

        protected override bool OnProcessCall(ProcessCallArgs args, out object[] results, out OutProcessNode nextNode)
        {
            if (!InItemNodes[0].GetItemFromConnectedNode(args, out object value))
            {
                results = null;
                nextNode = null;
                return false;
            }

            // cast
            try
            {
                T a = (T) value;
                results = new object[] {a};
                nextNode = OutProcessNode;
                return true;
            }
            catch (InvalidCastException ex)
            {
                results = null;
                nextNode = null;
                return false;
            }
        }

        public override string GetGraphName() => "CastGraph<"+typeof(T).Name+">";
    }
}