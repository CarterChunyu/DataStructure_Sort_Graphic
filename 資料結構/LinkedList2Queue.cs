using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class LinkedList2Queue<E> : IQueue<E>
    {
        private LinkedList2<E> l;

        public LinkedList2Queue()
        {
            this.l = new LinkedList2<E>();
        }

        public int Count { get { return this.l.Count; } }

        public bool IsEmpty { get { return this.l.IsEmpty; } }

        public E Dequeue()
        {
            return l.RemoveFirst();
        }

        public void Enqueue(E e)
        {
            this.l.AddLast(e);
        }

        public E Peek()
        {
            return this.l.GetFirst();
        }
    }
}
