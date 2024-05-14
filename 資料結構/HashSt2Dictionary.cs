using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 資料結構
{
    public class HashSt2Dictionary<Key, Value> : Idictionary<Key, Value> where Key : IComparable<Key>
    {
        private HashSt2<Key, Value> hashSt2;
        public HashSt2Dictionary()
        {
            this.hashSt2 = new HashSt2<Key, Value>();
        }
        public int Count { get {  return this.hashSt2.Count; } }

        public bool IsEmpty { get { return this.hashSt2.IsEmpty; } }

        public void Add(Key key, Value value)
        {
            hashSt2.Add(key, value);
        }

        public bool ContainsKey(Key key)
        {
            return hashSt2.Contains(key);
        }

        public Value Get(Key key)
        {
            return this.hashSt2.Get(key);
        }

        public void Remove(Key key)
        {
            this.hashSt2.Remove(key);
        }

        public void Set(Key key, Value value)
        {
            this.hashSt2.Set(key, value);
        }
    }
}
