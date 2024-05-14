using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class RBT2<Key, Value> where Key : IComparable<Key>
    {
        private const bool Red = true;
        private const bool Black = false;
        private class Node
        {
            public Key key;
            public Value value;
            public Node? left;
            public Node? right;
            public bool color;

            public Node(Key key, Value value)
            {
                this.key = key;
                this.value = value;
                this.left = null;
                this.right = null;
                this.color = Red;
            }

            public override string ToString()
            {
                return $"{key}-{value}";
            }
        }

        private int N;
        private Node root;

        public RBT2()
        {
            this.N = 0;
            this.root = null;
        }

        public int Count { get { return N; } }
        public bool IsEmpty { get { return this.N == 0; } }

        private bool IsRed(Node node)
        {
            if (node == null)
                return Black;
            return node.color;
        }

        private Node LeftRotate(Node node)
        {
            Node x = node.right;
            node.right = x.left;
            x.left = node;
            x.color = node.color;
            node.color = Red;
            return x;
        }


        private Node RightRotate(Node node)
        {
            Node x = node.left;
            node.left = x.right;
            x.right = node;
            x.color = node.color;
            node.color = Red;
            return x;
        }

        private void FlipColor(Node node)
        {
            node.left.color = Black;
            node.right.color = Black;
            node.color = Red;
        }

        public void Add(Key key, Value value)
        {
            this.root = Add(this.root, key, value);
            this.root.color = Black;
        }

        private Node Add(Node node, Key key, Value value)
        {
            if (node == null)
            {
                N++;
                return new Node(key, value);
            }

            if (key.CompareTo(node.key) < 0)
                node.left = Add(node.left, key, value);
            if (key.CompareTo(node.key) > 0)
                node.right = Add(node.right, key, value);

            if (!IsRed(node.left) && IsRed(node.right))
                node = LeftRotate(node);
            if (IsRed(node.left) && IsRed(node.left.left))
                node = RightRotate(node);
            if (IsRed(node.left) && IsRed(node.right))
                FlipColor(node);
            return node;
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
    }
}
