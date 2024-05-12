using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class Array2<E>
    {
        private int N;
        private int a;
        private int r;
        private E[] data;

        public Array2(int capacity)
        {
            this.data = new E[capacity];
            this.N = 0;
            this.a = 0;
            this.r = 0;
        }

        public Array2() : this(10)
        {

        }

        public int Count { get { return this.N; } }
        public bool IsEmpty { get { return this.N == 0; } }

        public void ResetCapacity(int capacity)
        {
            E[] temp = new E[capacity];
            for (int i = 0; i < N; i++)
            {
                temp[i] = this.data[(r + i) % this.data.Length];
            }
            this.a = N ;
            this.r = 0;
            this.data = temp;
        }

        public void Add(E e)
        {
            if(N == this.data.Length)
                ResetCapacity(this.data.Length*2);

            this.data[a] = e;
            a = (a + 1) % this.data.Length;
            N++;
        }

        public E Remove()
        {
            if (N == 0)
                throw new ArgumentException("空數組");
            E remove = this.data[r];
            this.data[r] = default(E);
            r = (r+1)%this.data.Length;
            N--;
            if (N == this.data.Length / 4)
                ResetCapacity(this.data.Length / 2);
            return remove;
        }

        public E Get()
        {
            if (N == 0)
                throw new ArgumentException("空數組");
            return this.data[r];
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                builder.Append(this.data[(r + i) % this.data.Length]);
                if(i<N-1)
                    builder.Append(", ");
            }
            return builder.ToString();
        }
    }
}
