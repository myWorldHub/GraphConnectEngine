using System;
using System.Threading.Tasks;

namespace GraphConnectEngine.Core.Variable
{
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