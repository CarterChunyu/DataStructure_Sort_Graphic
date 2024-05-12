using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class LinkedList3Dictionary<Key, Value> : IDictionary<Key, Value>
    {
        private LinkedList3<Key, Value> l;

        public LinkedList3Dictionary()
        {
            this.l = new LinkedList3<Key, Value>();
        }

        public int Count { get { return this.l.Count; } }

        public bool IsEmpty { get { return this.l.IsEmpty; } }

        public void Add(Key key, Value value)
        {
            this.l.Add(key, value);
        }

        public bool ContainsKey(Key key)
        {
            return l.Contains(key);
        }

        public Value Get(Key key)
        {
            return this.l.Get(key);
        }

        public void Remove(Key key)
        {
            l.Remove(key);
        }

        public void Set(Key key, Value value)
        {
            this.l.Set(key, value);
        }
    }
}
