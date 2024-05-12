using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class Array2Queue<E> : IQueue<E>
    {
        private Array2<E> arr;

        public Array2Queue(int capacity)
        {
            this.arr = new Array2<E>(capacity);
        }

        public Array2Queue()
        {
            this.arr = new Array2<E>();
        }

        public int Count { get { return this.arr.Count; } }

        public bool IsEmpty { get { return this.arr.IsEmpty; } }

        public E Dequeue()
        {
            return this.arr.Remove();
        }

        public void Enqueue(E e)
        {
            this.arr.Add(e);
        }

        public E Peek()
        {
            return this.arr.Remove();
        }
    }
}
