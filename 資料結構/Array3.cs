using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class Array3<E> where E : IComparable<E>
    {
        private int N;
        private E[] data;

        public Array3(int capacity)
        {
            this.N = 0;
            this.data = new E[capacity];
        }

        public Array3() : this(10)
        {

        }

        public int IndexOf(int target)
        {
            int l = 0;
            int r = data.Length;

            while (l <= r)
            {
                int mid = (r - l) / 2 + l;
                if (target.CompareTo(data[mid]) < 0)
                    r = mid - 1;
                else if (target.CompareTo(data[mid]) > 0)
                    l = mid + 1;
                else
                    return -1;
            }
            return l;
        }
    }
}
