using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class MaxPQ<E> : IQueue<E> where E : IComparable<E>
    {
        private MaxHeap<E> heap;

        public MaxPQ(int capacity)
        {
            heap = new MaxHeap<E>(capacity);
        }

        public MaxPQ():this(10) { }

        public int Count { get { return this.heap.Count; } }

        public bool IsEmpty { get { return this.heap.IsEmpty; } }   
 

        public E Peek()
        {
            return this.heap.Max();
        }

        public E Dequeue()
        {
            return this.heap.RemoveMax();
        }

        public void Enqueue(E e)
        {
            this.heap.Add(e);
        }

        public override string ToString()
        {
            return this.heap.ToString();
        }
    }
}
