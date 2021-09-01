using System;
using System.Collections.Generic;

namespace GraphConnectEngine.Core
{
    /// <summary>
    /// TODO 値が追加、削除された時にGetVariableGraphとかでタイプとかを更新する
    /// </summary>
    public class VariableHolder
    {
        private VariableHolder _parent;
        
        private readonly Dictionary<string, object> _items = new Dictionary<string, object>();
        private readonly Dictionary<string, Type> _types = new Dictionary<string, Type>();

        public void SetParent(VariableHolder parent)
        {
            _parent = parent;
        }

        public bool HasItem(string name,int depth = -1)
        {
            if (depth == 0)
                return false;
            return _items.ContainsKey(name) || (_parent != null && _parent.HasItem(name,depth-1));
        }

        public object GetItem(string name,int depth = -1,bool searched = false)
        {
            if (!searched)
            {
                if (HasItem(name, depth))
                {
                    searched = true;
                }
                else
                {
                    return null;
                }
            }
            return _items.ContainsKey(name) ? _items[name] : _parent?.GetItem(name,depth-1,true);
        }

        public bool TryGetItem(string name,out object obj,int depth = -1)
        {
            obj = GetItem(name,depth);
            return obj != null;
        }

        public Type GetItemType(string name,int depth = -1,bool searched = false)
        {
            if (!searched)
            {
                if (HasItem(name, depth))
                {
                    searched = true;
                }
                else
                {
                    return null;
                }
            }
            return _types.ContainsKey(name) ? _types[name] : _parent?.GetItemType(name,depth-1,true);
        }

        public bool TryGetItemType(string name, out Type type,int depth = -1)
        {
            type = GetItemType(name,depth);
            return type != null;
        }

        public bool TryCreateItem(string name, object obj)
        {
            if (!HasItem(name))
            {
                _items.Add(name,obj);
                _types.Add(name,obj.GetType());
                return true;
            }
            return false;
        }

        public bool TryCreateItem(string name, Type type)
        {
            if (!HasItem(name))
            {
                _items.Add(name,null);
                _types.Add(name,type);
                return true;
            }
            return false;
        }

        public bool UpdateItem(string name, object obj)
        {
            if (_items.ContainsKey(name))
            {
                if (_types[name] == obj.GetType() || obj.GetType().IsSubclassOf(_types[name]))
                {
                    _items[name] = obj;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return _parent?.UpdateItem(name, obj) ?? false;
            }
        }
    }
}