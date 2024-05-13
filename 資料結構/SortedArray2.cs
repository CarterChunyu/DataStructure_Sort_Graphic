using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class SortedArray2<Key,Value> where Key:IComparable<Key>
    {
        private Key[] Keys;
        private Value[] Values;
        private int N;

        public SortedArray2(int capacity)
        {
            this.Keys = new Key[capacity];
            this.Values = new Value[capacity];
            this.N = 0;
        }

        public SortedArray2() : this(10)
        {

        }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }  

        private void ResetCapacity(int capacity)
        {
            Key[] keysTemp = new Key[capacity];
            Value[] valueTemp = new Value[capacity];

            for (int i = 0; i < N ; i++)
            {
                keysTemp[i] = this.Keys[i];
                valueTemp[i] = this.Values[i];
            }

            this.Keys = keysTemp;
            this.Values = valueTemp;
        }



        public int Rank(Key key)
        {
            int l = 0;
            int r = N - 1;

            while(l<= r)
            {
                int mid = (r - l) / 2 + l;
                if (key.CompareTo(Keys[mid]) == 0)
                    return mid;
                else if (key.CompareTo(Keys[mid]) < 0)
                    r = mid - 1;
                else
                    l = mid + 1;
            }
            return l;
        }

        public void Add(Key key, Value value)
        {
            int index = Rank(key);
            if (index < N && key.CompareTo(Keys[index]) == 0)
                this.Values[index] = value;

            if (N == this.Keys.Length)
                ResetCapacity(2 * this.Keys.Length);

            for (int i = N-1; i >= index ; i--)
            {
                this.Keys[i + 1] = this.Keys[i];
                this.Values[i + 1] = this.Values[i];
            }

            this.Keys[index] = key;
            this.Values[index]= value;
            N++;
        }

        public void Remove(Key key)
        {
            int index = Rank(key);
            if(index < N && key.CompareTo(Keys[index])==0)
            {
                for (int i = index; i < N-1; i++)
                {
                    this.Keys[i] = this.Keys[i + 1];
                    this.Values[i] = this.Values[i + 1];
                }
                this.Keys[N - 1] = default(Key);
                this.Values[N - 1] = default(Value);
                N--;
            }
        }

        public Key Max()
        {
            if (N == 0)
                throw new ArgumentException("空數組");
            return this.Keys[N - 1];
        }

        public Key Min()
        {
            if (N == 0)
                throw new ArgumentException("空數組");
            return this.Keys[0];
        }

        public Key Select(int index)
        {
            if(index<0 || index >= N)
                throw new ArgumentException("索引越界");
            return this.Keys[index];
        }

        public Key Floor(Key key)
        {
            int index = Rank(key);
            if(index < N && key.CompareTo(this.Keys[index]) == 0)
                return this.Keys[index];
            if (index == 0)
                throw new ArgumentException($"沒有小於或等於{key}的數");
            return this.Keys[index-1];
        }

        public Key Ceiling(Key Key)
        {
            int index = Rank(Key);
            if (index == N)
                throw new ArgumentException("沒有大於或等於{key}的數");
            return this.Keys[index];
        }

        public bool Contains(Key key)
        {
            int index = Rank(key);
            if(index < N && key.CompareTo(Keys[index])==0)
                return true; 
            return false;
        }

        public Value Get(Key key)
        {
            int index = Rank(key);
            if (index < N && key.CompareTo(Keys[index]) == 0)
                return Values[index];
            throw new ArgumentException($"沒有這個Key");
        }

        public void Set(Key key, Value value)
        {
            int index = Rank(key);
            if (index == N || key.CompareTo(this.Keys[index]) != 0)
                throw new ArgumentException("沒有這個Key");
            this.Values[index] = value;
        }
    }
}
