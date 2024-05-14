using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class BST2<Key,Value> where Key : IComparable<Key>
    {
        private class Node
        {
            public Key key;
            public Value value;
            public Node? left;
            public Node? right;

            public Node(Key key, Value value)
            {
                this.key = key;
                this.value = value;
                this.left = null;
                this.right = null;
            }

            public override string ToString()
            {
                return $"{key}-{value}";
            }
        }

        private int N;
        private Node? root;

        public BST2()
        {
            this.N = 0;
            this.root = null;
        }

        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }

        public void Add(Key key, Value value)
        {
            this.root = Add(this.root, key, value);
        }

        private Node Add(Node? node, Key key, Value value)
        {
            if (node == null)
            {
                N++;
                return new Node(key, value);
            }

            if (key.CompareTo(node.key) < 0)
                node.left = Add(node.left, key, value);
            else if (key.CompareTo(node.key) > 0)
                node.right = Add(node.right, key, value);
            return node;
        }

        public Key Max()
        {
            if (this.root == null)
                throw new ArgumentException("空樹");
            return Max(this.root).key;
        }

        private Node Max(Node node)
        {
            if (node.right != null)
                return Max(node.right);
            return node;
        }

        public Key Min()
        {
            if (this.root == null)
                throw new ArgumentException("空樹");
            return Min(this.root).key;
        }

        private Node Min(Node node)
        {
            if (node.left != null)
                return Max(node.left);
            return node;
        }

        public void RemoveMax()
        {
            if (this.root == null)
                throw new ArgumentException("空樹");
            this.root = this.RemoveMax(this.root);
        }

        private Node? RemoveMax(Node? node)
        {
            if (node.right != null)
            {
                node.right = RemoveMax(node.right);
                return node;
            }
            return null;
        }

        public void Remove(Key key)
        {
            this.root = Remove(this.root, key);
        }

        private Node? Remove(Node? node, Key key)
        {
            if (node == null)
                return null;
            if (key.CompareTo(node.key) < 0)
            {
                node.left = Remove(node.left, key);
                return node;
            }
            else if (key.CompareTo(node.key) > 0)
            {
                node.right = Remove(node.right, key);
                return node;
            }
            else // key.CompareTo(node.key) == 0
            {
                if (node.left == null)
                    return node.right;
                else if (node.right == null)
                    return node.left;
                Node max = Max(node.left);
                max.left = node.left;
                max.right = RemoveMax(node.right);
                return max;
            }
        }

        public bool Contains(Key key)
        {
            return Contains(this.root, key);
        }

        private bool Contains(Node? node, Key key)
        {
            if (node == null)
                return false;

            if (key.CompareTo(node.key) < 0)
                return Contains(node.left, key);
            else if (key.CompareTo(node.key) > 0)
                return Contains(node.right, key);
            else
                return true;
        }

        public int MaxHeight()
        {
            return MaxHeight(this.root);
        }

        private int MaxHeight(Node? node)
        {
            if (node == null)
                return 0;
            return 1 + Math.Max(MaxHeight(node.left), MaxHeight(node.right));
        }

        private Node? GetNode(Node? node, Key key)
        {
            if (node == null)
                return null;
            if (key.CompareTo(node.key) < 0)
                return GetNode(node.left, key);
            else if (key.CompareTo(node.key) > 0)
                return GetNode(node.right, key);
            else
                return node;
        }

        public Value Get(Key key)
        {
            Node node = GetNode(this.root, key);
            if (node == null)
                throw new ArgumentException("沒有此鍵");
            return node.value;
        }

        public void Set(Key key, Value value)
        {
            Node node = GetNode(this.root, key);
            if (node == null)
                throw new ArgumentException("沒有此鍵");
            node.value = value; 
        }

        public int Rank(Key key)
        {
            return Rank(this.root, key);
        }

        private int Rank(Node? node, Key key)
        {
            if (node == null)
                return 0;
            if (key.CompareTo(node.key) > 0)
                return 1 + Rank(node.left, key) + Rank(node.right, key);
            else
                return Rank(node.left, key);
        }

        public Key Select(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("索引越界");
            return Select(this.root, index).key;
        }

        private Node Select(Node node, int index)
        {
            if (index < Rank(node.key))
                return Select(node.left, index);
            else if (index > Rank(node.key))
                return Select(node.right, index);
            else
                return node;
        }

        public Key Ceiling(Key key)
        {
            Node? node = Ceiling(this.root, key);
            if (node == null)
                throw new ArgumentException($"沒有大於或等於{key}的樹");
            return node.key;
        }

        private Node? Ceiling(Node? node, Key key)
        {
            if (node == null)
                return null;
            if (key.CompareTo(node.key) == 0)
                return node;
            else if (key.CompareTo(node.key) > 0)
                return Ceiling(node.right, key);
            else // key.CompareTo(node.key) > 0
                return Ceiling(node.left, key) != null ? Ceiling(node.left, key) : node;
        }

        public Key Floor(Key key)
        {
            Node? node = Floor(this.root, key);
            if (node == null)
                throw new ArgumentException($"沒有大於或等於{key}的樹");
            return node.key;
        }

        private Node? Floor(Node? node, Key key)
        {
            if (node == null)
                return null;
            if (key.CompareTo(node.key) == 0)
                return node;
            else if (key.CompareTo(node.key) < 0)
                return Floor(node.left, key);
            else // key.CompareTo(node.key) > 0
                return Floor(node.right, key) != null ? Floor(node.right, key) : node;
        }

        public void PreOrder()
        {
            PreOrder(this.root);
        }

        private void PreOrder(Node? node)
        {
            if (node == null)
                return;
            PreOrder(node.left);
            Console.WriteLine(node);
            PreOrder(node.right);
        }

        public void InOrder()
        {
            InOrder(this.root);
        }

        private void InOrder(Node node)
        {
            if (node == null)
                return;
            Console.WriteLine(node);
            InOrder(node.left);
            InOrder(node.right);
        }

        public void PostOrder()
        {
            PostOrder(this.root);
        }

        private void PostOrder(Node node)
        {
            if (node == null)
                return;
            PostOrder(node.left);
            PostOrder(node.right);
            Console.WriteLine(node);

        }
    }
}
