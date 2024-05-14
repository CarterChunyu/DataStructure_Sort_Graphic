using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class RBT1Set<Key> : Iset<Key> where Key : IComparable<Key>
    {
        private RBT1<Key> rBT;
        public RBT1Set()
        {
            this.rBT = new RBT1<Key>();
        }
        public int Count { get { return rBT.Count; } }

        public bool IsEmpty { get { return rBT.IsEmpty; } }

        public void Add(Key e)
        {
            rBT.Add(e);
        }

        public bool Contains(Key e)
        {
            return rBT.Contains(e);
        }

        public void Remove(Key e)
        {
            throw new NotImplementedException();
        }
    }
}
