using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Variable
{
    /// <summary>
    /// IVariableHolderのAsync版
    ///
    /// 関数の説明はVariableHolderを参照してください
    /// </summary>
    public interface IVariableHolderAsync
    {
        Task<bool> ContainsKeyAsync(string key);
        
        Task<ValueResult<T>> TryGetAsync<T>(string key);

        Task<ValueResult<object>> TryGetAsync(string key);

        Task<ValueResult<Type>> TryGetVariableType(string key);

        Task<bool> TryCreate(string key, object obj);

        Task<bool> TryCreate(string key, Type type);

        Task<bool> Update(string key, object obj);

        Task<bool> Remove(string name);

        Task<string[]> Keys();
    }
}