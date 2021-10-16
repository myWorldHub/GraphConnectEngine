using System;
using System.Threading.Tasks;
using GraphConnectEngine.Nodes;

namespace GraphConnectEngine.Graphs.Event
{
    /// <summary>
    /// プロセスを発生させるグラフ
    ///
    /// ### 実行モード
    /// * Time : Updateに経過時間を渡すことで、定期的に実行できる
    /// * Update : Updateが呼ばれるたびに処理を開始する
    /// </summary>
    public class UpdaterGraph : Graph
    {
        public enum Type
        {
            Update,
            Time
        }

        private Type _intervalType = Type.Update;
        
        /// <summary>
        /// Updaterのモード
        /// Update / Time
        /// </summary>
        public Type IntervalType
        {
            get => _intervalType;
            set => _intervalType = value;
        }
        
        private float _intervalTime = 1;
        
        /// <summary>
        /// モードがTimeの時、何秒ごとに実行するかを設定する
        /// 時間は0以上でなければいけない
        /// </summary>
        public float IntervalTime
        {
            get => _intervalTime;
            set
            {
                if(value > 0)
                    _intervalTime = value;
            }
        }

        private float _time;

        private IProcessSender _processSender;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="connector">コネクター</param>
        /// <param name="processSender">プロセスを呼ぶためのインターフェース</param>
        public UpdaterGraph(INodeConnector connector, IProcessSender processSender) : base(connector)
        {
            _time = 0;
            _processSender = processSender;
        }
        
        /// <summary>
        /// 次の実行までの残り時間をIntervalTime秒に戻す
        /// </summary>
        public void ResetTime()
        {
            _time = IntervalTime;
        }

        /// <summary>
        /// 時間を更新するグラフ
        ///
        /// Updateモードの場合は毎回プロセスを発生させる。
        /// Timeモードの場合はIntervalTime秒ごとにプロセスを発生させる
        /// </summary>
        /// <param name="deltaTime"></param>
        /// <returns></returns>
        public async Task<bool> Update(float deltaTime)
        {
            bool isZeroTime = _time >= 0 && _time - deltaTime < 0;
            _time -= deltaTime;
            
            if (IntervalType == Type.Update)
            {
                await _processSender.Fire(this,null);
                return true;
            }
            else
            {
                if (_time <= 0)
                {
                    ResetTime();
                }
                
                if (isZeroTime)
                {
                    await _processSender.Fire(this,null);
                    return true;
                }
            }

            return false;
        }

        public override Task<ProcessCallResult> OnProcessCall(ProcessCallArgs args, object[] parameters)
        {
            return Task.FromResult(ProcessCallResult.Success(Array.Empty<object>(), OutProcessNodes[0]));
        }

        public override string GraphName =>  "Updater Graph";
    }
}
