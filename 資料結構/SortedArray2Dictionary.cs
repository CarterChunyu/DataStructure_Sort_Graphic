using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class SortedArray2Dictionary<Key, Value> : Idictionary<Key, Value> where Key : IComparable<Key>
    {
        private SortedArray2<Key, Value> data;

        public SortedArray2Dictionary(int capacity)
        {
            this.data = new SortedArray2<Key, Value>(capacity);
        }

        public SortedArray2Dictionary()
        {
            this.data = new SortedArray2<Key, Value>();
        }
        public int Count { get { return this.data.Count; } }

        public bool IsEmpty { get { return this.data.IsEmpty; } }

        public void Add(Key key, Value value)
        {
            this.data.Add(key, value);
        }

        public bool ContainsKey(Key key)
        {
           return this.data.Contains(key);
        }

        public Value Get(Key key)
        {
            return this.data.Get(key);
        }

        public void Remove(Key key)
        {
            this.data.Remove(key);
        }

        public void Set(Key key, Value value)
        {
            this.data.Set(key, value);
        }
    }
}
