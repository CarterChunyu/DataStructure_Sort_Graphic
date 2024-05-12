using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class Array1<E> 
    {
        public E[] data;
        private int n;
        
        public Array1(int capacity)
        {
            this.data = new E[capacity];
            this.n = 0;
        }

        public Array1() : this(10)
        {

        }

        public int Count { get { return this.n; } }
        public bool IsEmpty { get { return n == 0; } }

        public void Add(int index,E value)
        {
            if(index < 0 || index > n)
                throw new ArgumentException("索引越界");

            if(n==this.data.Length)
                ResetCapacity(2*this.data.Length);

            for (int i = n-1; i >= index ; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = value;
            n++;
        }

        public void AddFirst(E value)
        {
            Add(0,value);
        }

        public void AddLast(E value)
        {
            Add(n, value);
        }

        private void ResetCapacity(int capacity)
        {
            E[] temp = new E[capacity];
            for (int i = 0; i < n ; i++)
            {
                temp[i] = this.data[i];
            }
            this.data = temp;
        }

        public E Get(int index)
        {
            if (index<0 || index >= this.n)
                throw new ArgumentException("越界");
            return this.data[index];
        }

        public E GetFirst()
        {
            return this.Get(0);
        }

        public E getLast()
        {
            return this.Get(n - 1);
        }

        public void Set(int index,E value)
        {
            if ( index < 0 || index >= this.n)
                throw new ArgumentException("越界");
            this.data[index] = value;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0;i < n ; i++)
            {
                builder.Append(this.data[i]);
                if(i<n-1)
                    builder.Append(", ");
            }
            return builder.ToString();
        }

        public bool Contains(E value)
        {
            for (int i = 0; i < n; i++)
            {
                if(value.Equals(this.data[i]))
                    return true; 
            }
            return false;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < n; i++)
            {
                if (value.Equals(this.data[i]))
                    return i;
            }
            return -1;
        }

        public E RemoveAt(int index)
        {
            if (index < 0 || index >= n)
                throw new ArgumentException("越界");

            E remove = this.data[index];
            for (int i = index; i < n; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.data[n-1] = default(E);
            this.n--;
            if (this.n == this.data.Length / 4)
                ResetCapacity(this.data.Length/2);
            return remove;
        }

        public E RemoveFirst()
        {
            return RemoveAt(0);
        }

        public E RemoveLast()
        {
            return RemoveAt(this.n-1);
        }

        public void Remove(int e)
        {
            int index = IndexOf(e);
            if (e == -1)
                throw new ArgumentException("此數不存在數組中");
            RemoveAt(index); 
        }
    }
}
