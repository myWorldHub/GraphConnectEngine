using GraphConnectEngine.Nodes;
using GraphConnectEngine.Variable;

namespace GraphConnectEngine.Graphs.Variable
{
    /// <summary>
    /// IVariableHolderAsyncを使うグラフ
    /// 抽象クラス
    /// </summary>
    public abstract class VariableAsyncGraph : Graph
    {

        private IAsyncVariableHolder _holder;

        /// <summary>
        /// IVariableHolderのプロパティ
        /// </summary>
        public IAsyncVariableHolder Holder
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
        /// <param name="holder">IVariableHolder</param>
        protected VariableAsyncGraph(string id, IAsyncVariableHolder holder) : base(id)
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
