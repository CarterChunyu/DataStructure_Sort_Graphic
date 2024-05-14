using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class RBT2Dictionary<Key, Value> : Idictionary<Key, Value> where Key : IComparable<Key>
    {
        private RBT2<Key,Value> rBT2;
        public RBT2Dictionary()
        {
            this.rBT2 = new RBT2<Key, Value>();
        }

        public int Count { get { return this.rBT2.Count; } }
        public bool IsEmpty { get { return this.rBT2.IsEmpty; } }

        public void Add(Key key, Value value)
        {
            this.rBT2.Add(key, value);
        }

        public bool ContainsKey(Key key)
        {
            return rBT2.Contains(key);
        }

        public Value Get(Key key)
        {
            return rBT2.Get(key);
        }

        public void Remove(Key key)
        {
            throw new NotImplementedException();
        }

        public void Set(Key key, Value value)
        {
            this.rBT2.Set(key, value);
        }
    }
}
