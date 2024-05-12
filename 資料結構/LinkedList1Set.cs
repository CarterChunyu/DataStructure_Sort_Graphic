using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class LinkedList1Set<E> : ISet<E>
    {
        private LinkedList1<E> l;

        public LinkedList1Set()
        {
            this.l = new LinkedList1<E>();
        }
        public int Count { get { return this.l.Count; } }

        public bool IsEmpty { get { return this.l.IsEmpty; } }

        int ISet<E>.Count { get { return this.l.Count; } }


        public void Add(E e)
        {
            if (!this.l.Contains(e))
                l.AddFirst(e);
        }

        public bool Contains(E e)
        {
            return this.l.Contains(e);
        }

        public void Remove(E e)
        {
            this.l.Remove(e);
        }

        void ISet<E>.Add(E e)
        {
            this.Add(e);
        }
    }
}
