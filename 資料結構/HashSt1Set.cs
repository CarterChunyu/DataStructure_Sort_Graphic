using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class HashSt1Set<Key> : Iset<Key> where Key : IComparable<Key>
    {
        private HashSt1<Key> hashSt1;

        public HashSt1Set()
        {
            this.hashSt1 = new HashSt1<Key>();
        }

        public int Count { get {  return this.hashSt1.Count; } } 

        public bool IsEmpty { get {  return this.hashSt1.IsEmpty; } }

        public void Add(Key e)
        {
            hashSt1.Add(e);
        }

        public bool Contains(Key e)
        {
            return hashSt1.Contains(e);
        }

        public void Remove(Key e)
        {
            hashSt1.Remove(e);
        }
    }
}
