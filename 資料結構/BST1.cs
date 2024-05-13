using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class BST1<Key> where Key : IComparable<Key>
    {
        private class Node
        {
            public Key key;
            public Node? left;
            public Node? right;

            public Node(Key key)
            {
                this.key = key;
                this.left = null;
                this.right = null;
            }

            public override string ToString()
            {
                return key.ToString();
            }
        }

        private int N;
        private Node? root;

        public BST1()
        {
            this.N = 0;
            this.root = null;
        }

        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }

        public void Add(Key key)
        {
            this.root = Add(this.root, key);
        }

        private Node Add(Node? node, Key key)
        {
            if (node == null)
            {
                N++;
                return new Node(key);
            }

            if (key.CompareTo(node.key) < 0)
                node.left = Add(node.left, key);
            else if (key.CompareTo(node.key) > 0)
                node.right = Add(node.right, key);
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
            this.root  = this.RemoveMax(this.root);
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

        private Node? Remove(Node? node,Key key)
        {
            if (node == null)
                return null;
            if (key.CompareTo(node.key) < 0)
            {
                node.left = Remove(node.left, key);
                return node;
            }
            else if(key.CompareTo(node.key) > 0)
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
    }
}
