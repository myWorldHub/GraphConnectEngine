using System;

namespace GraphConnectEngine.Core.Variable
{
    public interface IVariableHolder
    {

        /// <summary>
        /// 存在確認
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool ContainsKey(string key);


        /// <summary>
        /// 値をキャストして取得
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        ValueResult<T> TryGet<T>(string key);

        /// <summary>
        /// 値を取得
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        ValueResult<object> TryGet(string key);

        /// <summary>
        /// 型を取得
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        ValueResult<Type> TryGetVariableType(string key);


        /// <summary>
        /// 変数を作成
        /// </summary>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool TryCreate(string key, object obj);


        /// <summary>
        /// 変数を作成
        /// </summary>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool TryCreate(string key, Type type);

        /// <summary>
        /// 変数を更新
        /// </summary>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool Update(string key, object obj);

        /// <summary>
        /// 変数を削除
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool Remove(string name);

        /// <summary>
        /// 変数名たちを取得
        /// </summary>
        /// <returns></returns>
        string[] Keys();
    }



}