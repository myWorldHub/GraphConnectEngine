using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Variable
{
    /// <summary>
    /// IVariableHolderのAsync版
    ///
    /// 関数の説明はVariableHolderを参照してください
    /// </summary>
    public interface IAsyncVariableHolder : IVariableHolderEvent
    {
        Task<bool> ContainsKeyAsync(string key);
        
        Task<ValueResult<T>> TryGetAsync<T>(string key);

        Task<ValueResult<object>> TryGetAsync(string key);

        Task<ValueResult<Type>> TryGetVariableTypeAsync(string key);

        void CreateWithoutNotify(string key, object obj);

        Task<bool> TryCreateAsync(string key, object obj);

        Task<bool> TryCreateAsync(string key, Type type);

        Task<bool> UpdateAsync(string key, object obj);

        void UpdateWithoutNotify(string key, object obj);

        Task<bool> RemoveAsync(string name);

        void RemoveWithoutNotify(string name);

        Task<string[]> GetKeysAsync();
    }
}
