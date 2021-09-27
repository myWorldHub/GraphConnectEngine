using System;
using System.Collections.Generic;
using System.Linq;

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

        private bool _isDisposed = false;

        /// <summary>
        /// Get専用のIndexer
        /// </summary>
        /// <param name="key"></param>
        public object this[string key]
        {
            get => ContainsKey(key) ? _items[key] : null;
        }

        /// <summary>
        /// 存在確認
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsKey(string key)
        {
            return _items.ContainsKey(key);
        }
        
        /// <summary>
        /// 値をキャスとして取得
        /// </summary>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool TryGet<T>(string key, out T result)
        {
            if (ContainsKey(key))
            {
                if (_items[key] == null)
                {
                    result = default;
                    return true;
                }
                
                if (_items[key] is T t)
                {
                    result = t;
                    return true;
                }
            }

            result = default;
            return false;
        }

        /// <summary>
        /// 型を取得
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Type GetVariableType(string key)
        {
            return _types.ContainsKey(key) ? _types[key] : null;
        }

        /// <summary>
        /// 型を取得
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool TryGetVariableType(string key, out Type type)
        {
            type = GetVariableType(key);
            return type != null;
        }

        /// <summary>
        /// 変数を作成
        /// </summary>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool TryCreate(string key, object obj)
        {
            if (TryCreate(key,obj.GetType()))
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
        public bool TryCreate(string key, Type type)
        {
            if (!ContainsKey(key))
            {
                _items.Add(key,null);
                _types.Add(key,type);
                
                OnVariableCreated?.Invoke(this,new VariableCreatedEventArgs()
                {
                    Name = key,
                    Type = type
                });
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
        public bool Update(string key, object obj)
        {
            if (ContainsKey(key))
            {
                if (obj.GetType() != _types[key])
                    return false;

                _items[key] = obj;
                
                OnVariableUpdated?.Invoke(this,new VariableUpdatedEventArgs()
                {
                    Name = key,
                    Type = _types[key],
                    Value = obj
                });
            }
            return false;
        }

        /// <summary>
        /// 変数を削除
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Remove(string name)
        {
            if (_items.ContainsKey(name))
            {
                _items.Remove(name);
                _types.Remove(name);

                OnVariableRemoved?.Invoke(this,new VariableRemovedEventArgs()
                {
                    Name = name
                });
                
                return true;
            }
            return false;
        }

        /// <summary>
        /// 変数名たちを取得
        /// </summary>
        /// <returns></returns>
        public string[] GetItemNames()
        {
            return _items.Keys.ToArray();
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
        public string Name;
        public Type Type;
    }

    public class VariableUpdatedEventArgs : EventArgs
    {
        public string Name;
        public Type Type;
        public Object Value;
    }

    public class VariableRemovedEventArgs : EventArgs
    {
        public string Name;
    }
}
