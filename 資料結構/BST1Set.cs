using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class BST1Set<Key> : Iset<Key> where Key : IComparable<Key>
    {
        private BST1<Key> bst;
        
        public BST1Set()
        {
            this.bst = new BST1<Key>();
        }
        public int Count { get { return this.bst.Count; } }

        public bool IsEmpty { get { return this.bst.IsEmpty; } }

        public void Add(Key e)
        {
            this.bst.Add(e);
        }

        public bool Contains(Key e)
        {
            return this.bst.Contains(e);
        }

        public void Remove(Key e)
        {
            this.bst.Remove(e);
        }
    }
}
