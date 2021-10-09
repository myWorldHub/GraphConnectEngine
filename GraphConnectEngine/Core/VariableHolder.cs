using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphConnectEngine.Core
{
    /// <summary>
    /// 値保持用のクラス
    /// </summary>
    public class VariableHolder : IDisposable
    {
        
        private readonly Dictionary<string, object> _items = new Dictionary<string, object>();
        private readonly Dictionary<string, Type> _types = new Dictionary<string, Type>();

        public event EventHandler<VariableCreatedEventArgs> OnVariableCreated;
        public event EventHandler<VariableUpdatedEventArgs> OnVariableUpdated;
        public event EventHandler<VariableRemovedEventArgs> OnVariableRemoved;
        public event EventHandler<EventArgs> OnDisposed;

        private bool _isDisposed;

        /// <summary>
        /// 存在確認
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual Task<bool> ContainsKey(string key)
        {
            return Task.FromResult(_items.ContainsKey(key));
        }
        
        /// <summary>
        /// 値をキャストして取得
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public virtual async Task<ValueResult<T>> TryGet<T>(string key)
        {
            if (await ContainsKey(key))
            {
                if (_items[key] == null)
                    return ValueResult<T>.Success(default);
                
                if (_items[key] is T t)
                    return ValueResult<T>.Success(t);
            }
            return ValueResult<T>.Fail();
        }

        /// <summary>
        /// 値を取得
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual async Task<ValueResult<object>> TryGet(string key)
        {
            if (await ContainsKey(key))
            {
                if (_items[key] == null)
                    return ValueResult<object>.Success(default);

                if (_items[key] is object t)
                    return ValueResult<object>.Success(t);
            }

            return ValueResult<object>.Fail();
        }

        /// <summary>
        /// 型を取得
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual Task<Type> GetVariableType(string key)
        {
            return Task.FromResult(_types.ContainsKey(key) ? _types[key] : null);
        }

        /// <summary>
        /// 型を取得
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual async Task<ValueResult<Type>> TryGetVariableType(string key)
        {
            var type = await GetVariableType(key);
            return ValueResult<Type>.Create(type != null,type);
        }

        /// <summary>
        /// 変数を作成
        /// </summary>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual async Task<bool> TryCreate(string key, object obj)
        {
            if (await TryCreate(key,obj.GetType()))
            {
                _items[key] = obj;
                return true;
            }
            return false;
        }

        /// <summary>
        /// 変数を作成
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public virtual async Task<bool> TryCreate(string key, Type type)
        {
            if (!await ContainsKey(key))
            {
                _items.Add(key,null);
                _types.Add(key,type);

                OnVariableCreated?.Invoke(this, new VariableCreatedEventArgs(key,type));
                return true;
            }
            return false;
        }

        /// <summary>
        /// 変数を更新
        /// </summary>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual async Task<bool> Update(string key, object obj)
        {
            if (await ContainsKey(key))
            {
                if (obj != null && obj.GetType() != _types[key])
                    return false;

                _items[key] = obj;

                OnVariableUpdated?.Invoke(this, new VariableUpdatedEventArgs(key,_types[key],obj));

                return true;
            }
            return false;
        }

        /// <summary>
        /// 変数を削除
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public virtual async Task<bool> Remove(string name)
        {
            if (await ContainsKey(name))
            {
                _items.Remove(name);
                _types.Remove(name);

                OnVariableRemoved?.Invoke(this, new VariableRemovedEventArgs(name));
                return true;
            }
            return false;
        }

        /// <summary>
        /// 変数名たちを取得
        /// </summary>
        /// <returns></returns>
        public virtual Task<string[]> Keys()
        {
            return Task.FromResult(_items.Keys.ToArray());
        }

        ~VariableHolder()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (!_isDisposed)
            {
                _isDisposed = true;
                OnDisposed?.Invoke(this, new EventArgs());
            }
        }
    }

    public class VariableCreatedEventArgs : EventArgs
    {

        public VariableCreatedEventArgs(string name, Type type)
        {
            Name = name;
            Type = type;
        }
        
        public readonly string Name;
        public readonly Type Type;
    }

    public class VariableUpdatedEventArgs : EventArgs
    {

        public VariableUpdatedEventArgs(string name, Type type,Object value)
        {
            Name = name;
            Type = type;
            Value = value;
        }
        
        public readonly string Name;
        public readonly Type Type;
        public readonly Object Value;
    }

    public class VariableRemovedEventArgs : EventArgs
    {

        public VariableRemovedEventArgs(string name)
        {
            Name = name;
        }
        
        public readonly string Name;
    }
}
