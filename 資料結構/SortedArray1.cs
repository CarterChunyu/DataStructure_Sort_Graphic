using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 資料結構
{
    public class SortedArray1<E> where E : IComparable<E>
    {
        private int N;
        private E[] data;

        public SortedArray1(int capacity)
        {
            this.N = 0;
            this.data = new E[capacity];
        }

        public SortedArray1() : this(10)
        {

        }
        
        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }  

        public int Rank(E target)
        {
            int l = 0;
            int r = N-1;

            while (l <= r)
            {
                int mid = (r - l) / 2 + l;
                if (target.CompareTo(data[mid]) < 0)
                    r = mid - 1;
                else if (target.CompareTo(data[mid]) > 0)
                    l = mid + 1;
                else
                    return mid;
            }
            return l;
        }

        public void Add(E e)
        {
            int index = Rank(e);

            if (index< N && e.CompareTo(data[index]) == 0)
                return;

            if (N == this.data.Length)
                ResetCapacity(this.data.Length * 2);

            for (int i = N-1; i >= index; i--)
            {
                this.data[i + 1] = this.data[i];
            }
            this.data[index] = e;
            N++;
        }

        public void Remove(E e)
        {
            int index = Rank(e);

            //if (index < N && e.CompareTo(data[index]) == 0)
            //{
            //    for (int i = index; i < N-1; i++)
            //    {
            //        this.data[i] = this.data[i + 1];
            //    }
            //    this.data[N - 1] = default(E);
            //    N--;
            //}

            if (index == N || e.CompareTo(this.data[index]) < 0)
                return;

            for (int i = index; i < N - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.data[N - 1] = default(E);
            N--;
            if (N == this.data.Length / 4)
                ResetCapacity(this.data.Length / 2);
        }

        public void ResetCapacity(int capacity)
        {
            E[] temp = new E[capacity];
            for (int i = 0; i < N; i++)
            {
                temp[i] = this.data[i];
            }
            this.data = temp;
        }

        public E Min()
        {
            if (IsEmpty)
                throw new ArgumentException("空數組");
            return this.data[0];
        } 

        public E Max()
        {
            if (IsEmpty)
                throw new ArgumentException("空數組");
            return this.data[N-1];
        }

        public E Select(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("索引越界");
            return this.data[index];
        }

        public bool Contains(E e)
        {
            int index = Rank(e);
            if (index < N && e.CompareTo(this.data[index]) == 0)
                return true;
            return false;
        }

        public E Floor(E e)
        {
            int index = Rank(e);
            
            if(index < N && e.CompareTo(this.data[index])==0)
                return this.data[index];
            
            //if(index == 0)
            //    throw new ArgumentException("不存在小於或等於{e}的數");

            //return this.data[index - 1];

            if (index >= 1)
                return this.data[index - 1];
            throw new ArgumentException($"不存在小於或等於{e}的數");
        }

        public E Ceiling(E e)
        {
            int index = Rank(e);

            if (index == N)
                throw new ArgumentException($"不存在大於或等於{e}的數");
            return this.data[index];
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                builder.Append(this.data[i]);
                if (i < N - 1)
                    builder.Append(", ");
            }
            return builder.ToString();
        }
    }
}
