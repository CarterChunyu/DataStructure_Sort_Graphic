using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class Array1Stack<E> : IStack<E>
    {
        private Array1<E> arr;

        public Array1Stack(int capacity)
        {
            this.arr = new Array1<E>(capacity);
        }

        public Array1Stack()
        {
            this.arr = new Array1<E>();
        }

        public int Count { get { return this.arr.Count; } }

        public bool IsEmpty { get { return this.arr.IsEmpty; } }

        public E Peek()
        {
            return this.arr.getLast();
        }

        public E Pop()
        {
            return this.arr.RemoveLast();
        }

        public void Push(E e)
        {
            this.arr.AddLast(e);
        }
    }
}
