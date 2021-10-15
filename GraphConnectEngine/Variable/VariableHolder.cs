using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphConnectEngine.Variable
{
    /// <summary>
    /// 値保持用のクラス
    /// </summary>
    public class VariableHolder : IVariableHolder,IVariableHolderEvent,IDisposable
    {
        
        private readonly Dictionary<string, object> _items = new Dictionary<string, object>();
        
        private readonly Dictionary<string, Type> _types = new Dictionary<string, Type>();

        public event EventHandler<VariableCreatedEventArgs> OnVariableCreated;
        public event EventHandler<VariableUpdatedEventArgs> OnVariableUpdated;
        public event EventHandler<VariableRemovedEventArgs> OnVariableRemoved;
        public event EventHandler<EventArgs> OnDisposed;

        private bool _isDisposed;

        public bool ContainsKey(string key)
        {
            return _items.ContainsKey(key);
        }
        
        public ValueResult<T> TryGet<T>(string key)
        {
            if (ContainsKey(key))
            {
                if (_items[key] == null)
                    return ValueResult<T>.Success(default);
                
                if (_items[key] is T t)
                    return ValueResult<T>.Success(t);
            }
            return ValueResult<T>.Fail();
        }

        public ValueResult<object> TryGet(string key)
        {
            if (ContainsKey(key))
            {
                if (_items[key] == null)
                    return ValueResult<object>.Success(default);

                if (_items[key] is object t)
                    return ValueResult<object>.Success(t);
            }

            return ValueResult<object>.Fail();
        }
        
        public ValueResult<Type> TryGetVariableType(string key)
        {
            var type = _types.ContainsKey(key) ? _types[key] : null;
            return ValueResult<Type>.Create(type != null,type);
        }
        
        public bool TryCreate(string key, object obj)
        {
            if (TryCreate(key,obj.GetType()))
            {
                _items[key] = obj;
                return true;
            }
            return false;
        }

        public bool TryCreate(string key, Type type)
        {
            if (!ContainsKey(key))
            {
                _items.Add(key,null);
                _types.Add(key,type);

                OnVariableCreated?.Invoke(this, new VariableCreatedEventArgs(key,type));
                return true;
            }
            return false;
        }

        public bool Update(string key, object obj)
        {
            if (ContainsKey(key))
            {
                if (obj != null && obj.GetType() != _types[key])
                    return false;

                _items[key] = obj;

                OnVariableUpdated?.Invoke(this, new VariableUpdatedEventArgs(key,_types[key],obj));

                return true;
            }
            return false;
        }

        public bool Remove(string name)
        {
            if (ContainsKey(name))
            {
                _items.Remove(name);
                _types.Remove(name);

                OnVariableRemoved?.Invoke(this, new VariableRemovedEventArgs(name));
                return true;
            }
            return false;
        }

        public string[] Keys()
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

        private void Dispose(bool isDisposing)
        {
            if (!_isDisposed)
            {
                _isDisposed = true;
                OnDisposed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
