using GraphConnectEngine.Node;
using GraphConnectEngine.Variable;

namespace GraphConnectEngine.Graphs.Variable
{
    /// <summary>
    /// IVariableHolderを使うグラフ
    /// 抽象クラス
    /// </summary>
    public abstract class VariableGraph : Graph
    {

        private IVariableHolder _holder;

        /// <summary>
        /// IVariableHolderのプロパティ
        /// </summary>
        public IVariableHolder Holder
        {
            get => _holder;
            private set
            {
                _holder = value;
                OnHolderChanged();
            }
        }

        private string _variableName = "";

        /// <summary>
        /// 変数名のプロパティ
        /// </summary>
        public string VariableName
        {
            get => _variableName;
            set
            {
                _variableName = value;
                OnVariableChanged();
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="holder">IVariableHolder</param>
        protected VariableGraph(INodeConnector connector, IVariableHolder holder) : base(connector)
        {
            _holder = holder;
        }

        /// <summary>
        /// 変数名が変わった時に呼ばれる
        /// </summary>
        protected abstract void OnVariableChanged();

        /// <summary>
        /// IVariableHolderが変わったら呼ばれる
        /// </summary>
        protected abstract void OnHolderChanged();
        
    }
}