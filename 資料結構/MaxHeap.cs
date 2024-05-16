using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class MaxHeap<E> where E : IComparable<E>
    {
        private E[] data;
        private int N;

        public MaxHeap(int capacity)
        {
            this.data = new E[capacity];
        }

        public MaxHeap() : this(10)
        {

        }

        public int Count { get { return this.N; } }
        public bool IsEmpty { get { return this.N == 0; } }

        public void ResetCapacity(int capacity)
        {
            E[] temp = new E[capacity];
            for (int i = 1; i <= N; i++)
                temp[i] = this.data[i];
            this.data = temp;
        }

        public void Add(E e)
        {
            if (N + 1 == this.data.Length)
                ResetCapacity(this.data.Length * 2);
            N++;
            this.data[N] = e;
            Swim(N);
        }

        public void Swim(int index)
        {
            while(index > 1)
            {
                if (data[index].CompareTo(data[index / 2]) > 0)
                {
                    Swap(index, index / 2);
                    index = index / 2;
                }
                else
                    break;
            }
        }
        private void Swap(int i, int j)
        {
            E temp = this.data[i];
            this.data[i] = this.data[j];
            this.data[j] = temp;
        }

        public E RemoveMax()
        {
            E r = this.data[1];
            Swap(1, N);
            N--;
            Sink(1);
            if ((N + 1) == this.data.Length / 4)
                ResetCapacity(this.data.Length / 2);
            return r;
        }

        private void Sink(int index)
        {
            while(index*2 <= N)
            {
                int c = index * 2;
                if (index * 2 + 1 <= N && this.data[c].CompareTo(this.data[c + 1]) < 0)
                    c++;
                if (this.data[index].CompareTo(this.data[c]) > 0)
                    break;
                Swap(index, c);
                index = c;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 1; i <= N; i++)
            {
                builder.Append(this.data[i]);
                if(i<N)
                    builder.Append(", ");
            }
            return builder.ToString();
        }

        public E Max()
        {
            return this.data[0];
        }
    }
}
