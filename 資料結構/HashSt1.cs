using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class HashSt1<Key>
    {
        private LinkedList1<Key>[]? hashtable; 
        private int M;
        private int N;

        public HashSt1(int m)
        {
            this.N = 0;
            this.M = m;
            this.hashtable = new LinkedList1<Key>[M];
            for (int i = 0; i < m; i++)
            {
                this.hashtable[i] = new LinkedList1<Key>();
            }
        }

        public HashSt1(): this(97)
        {

        }

        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }

        private int Hash(Key key)
        {
           return (key.GetHashCode()& 0x7fffffff) % M;
        }

        public void Add(Key key)
        {
            int index = Hash(key);
            LinkedList1<Key> l = this.hashtable[index];
            if (!l.Contains(key))
            {
                l.AddFirst(key);
                N++;
            }
        }

        public void Remove(Key key)
        {
            int index = Hash(key);
            LinkedList1<Key> l = this.hashtable[index];
            if (!l.Contains(key))
            {
                l.Remove(key);
                N--;
            }
        }

        public bool Contains(Key key)
        {
            int index = Hash(key);
            LinkedList1<Key> l = this.hashtable[index];
            return l.Contains(key);
        }
    }
}
 