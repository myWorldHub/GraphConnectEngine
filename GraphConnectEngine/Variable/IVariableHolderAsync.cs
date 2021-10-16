using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Variable
{
    /// <summary>
    /// IVariableHolderのAsync版
    ///
    /// 関数の説明はVariableHolderを参照してください
    /// </summary>
    public interface IVariableHolderAsync : IVariableHolderEvent
    {
        Task<bool> ContainsKeyAsync(string key);
        
        Task<ValueResult<T>> TryGetAsync<T>(string key);

        Task<ValueResult<object>> TryGetAsync(string key);

        Task<ValueResult<Type>> TryGetVariableTypeAsync(string key);

        Task<bool> TryCreateAsync(string key, object obj);

        Task<bool> TryCreateAsync(string key, Type type);

        Task<bool> UpdateAsync(string key, object obj);

        Task<bool> RemoveAsync(string name);

        Task<string[]> GetKeysAsync();
    }
}