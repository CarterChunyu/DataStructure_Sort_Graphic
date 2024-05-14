using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class HashSt2<Key,Value> where Key : IComparable<Key>
    {
        private int N;
        private int M;
        private LinkedList3<Key, Value>[] hashtable;

        public HashSt2(int M)
        {
            this.N = 0;
            this.M = M;
            this.hashtable = new LinkedList3<Key, Value>[M];
            for (int i = 0; i < M; i++)
                this.hashtable[i] = new LinkedList3<Key, Value>();
        }

        public HashSt2() : this(97)
        {

        }

        public int Count { get { return this.N; } }
        public bool IsEmpty { get { return this.N== 0; } }

        private int Hash(Key key)
        {
            return (key.GetHashCode() & 0x7fffffff) % M;
        }

        public void Add(Key key, Value value)
        {
            int index = Hash(key);
            LinkedList3<Key, Value> l = this.hashtable[index]; 
            if(!l.Contains(key))
            {
                l.Add(key, value);
                N++;
            }
        }

        public void Remove(Key key)
        {
            int index = Hash(key);
            LinkedList3<Key, Value> l = this.hashtable[index];
            if (l.Contains(key))
            {
                l.Remove(key);
                N--;
            }
        }

        public bool Contains(Key key)
        {
            int index = Hash(key);
            LinkedList3<Key, Value> l = this.hashtable[index];
            return l.Contains(key);
        }

        public Value Get(Key key)
        {
            int index = Hash(key);
            LinkedList3<Key, Value> l = this.hashtable[index];
            if (!l.Contains(key))
                throw new ArgumentException("沒有此鍵");
            return l.Get(key);
        }

        public void Set(Key key, Value value)
        {
            int index = Hash(key);
            LinkedList3<Key, Value> l = this.hashtable[index];
            if (!l.Contains(key))
                throw new ArgumentException("沒有此鍵");
            l.Set(key, value);
        }
    }
}
