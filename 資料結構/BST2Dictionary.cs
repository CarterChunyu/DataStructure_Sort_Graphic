using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class BST2Dictionary<key, Value> : Idictionary<key, Value> where key : IComparable<key>
    {
        private BST2<key, Value> bst2;

        public BST2Dictionary()
        {
            this.bst2 = new BST2<key, Value>();
        }
        
        public int Count { get { return bst2.Count; } }

        public bool IsEmpty { get { return bst2.IsEmpty; } }

        public void Add(key key, Value value)
        {
            this.bst2.Add(key, value);
        }

        public bool ContainsKey(key key)
        {
            return this.bst2.Contains(key);
        }

        public Value Get(key key)
        {
            return this.bst2.Get(key);
        }

        public void Remove(key key)
        {
            this.bst2.Remove(key);
        }

        public void Set(key key, Value value)
        {
            this.bst2.Set(key, value);
        }
    }
}
