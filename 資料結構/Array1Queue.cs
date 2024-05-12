using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class Array1Queue<E> : IQueue<E>
    {
        private Array1<E> arr;

        public Array1Queue(int capacity)
        {
            this.arr = new Array1<E>(capacity);
        }

        public Array1Queue()
        {
            this.arr = new Array1<E>();
        }

        public int Count { get { return this.arr.Count; } }

        public bool IsEmpty { get { return this.arr.IsEmpty; } }

        public E Dequeue()
        {
            return this.arr.RemoveFirst();
        }

        public void Enqueue(E e)
        {
            this.arr.AddLast(e);
        }

        public E Peek()
        {
            return this.arr.GetFirst();
        }
    }
}
