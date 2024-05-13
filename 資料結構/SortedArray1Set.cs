using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class SortedArray1Set<E> : Iset<E> where E : IComparable<E>
    {
        private SortedArray1<E> data;

        public SortedArray1Set(int capacity)
        {
            this.data = new SortedArray1<E>(capacity);
        }

        public SortedArray1Set()
        {
            this.data = new SortedArray1<E>();
        }
        public int Count { get { return this.data.Count; } }

        public bool IsEmpty { get { return this.data.IsEmpty; } }

        public void Add(E e)
        {
            this.data.Add(e);
        }

        public bool Contains(E e)
        {
            return this.data.Contains(e);
        }

        public void Remove(E e)
        {
            this.data.Remove(e);
        }
    }
}
