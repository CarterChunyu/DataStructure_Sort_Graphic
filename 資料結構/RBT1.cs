using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class RBT1<Key> where Key : IComparable<Key>
    {
        private const bool Red = true;
        private const bool Black = false;
        private class Node
        {
            public Key key;
            public Node? left;
            public Node? right;
            public bool color;

            public Node(Key key)
            {
                this.key = key;
                this.left = null;
                this.right = null;
                this.color = Red;
            }

            public override string ToString()
            {
                return key.ToString();
            }
        }

        private int N;
        private Node root;

        public RBT1()
        {
            this.N = 0;
            this.root = null;
        }

        public int Count { get; set; }
        public bool IsEmpty { get; set; }

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

        public void Add(Key key)
        {
            this.root = Add(this.root, key);
            this.root.color = Black;
        }

        private Node Add(Node node, Key key)
        {
            if (node == null)
            {
                N++;
                return new Node(key);
            }

            if (key.CompareTo(node.key) < 0)
                node.left = Add(node.left, key);
            if (key.CompareTo(node.key) > 0)
                node.right = Add(node.right, key);

            if (!IsRed(node.left) && IsRed(node.right))
                node = LeftRotate(node);
            if(!IsRed(node.left) && IsRed(node.left.left))
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
    }
}
