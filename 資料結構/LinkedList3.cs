using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class LinkedList3<Key,Value>
    {
        private class Node
        {
            public Key key;
            public Value value;
            public Node next;

            public Node(Key key, Value value, Node next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }

            public Node(Key key, Value value) : this(key, value, null)
            {

            }

            public override string ToString()
            {
                return $"{this.key} : {this.value}";
            }
        }

        private int N;
        private Node head;

        public LinkedList3()
        {
            this.N = 0;
            this.head = null;
        }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        private Node? GetNode(Key key)
        {
            Node cur = this.head;
            while(cur != null)
            {
                if (key.Equals(cur.key))
                    return cur;
                cur = cur.next;
            }
            return null;
        }  

        public bool Contains(Key key)
        {
            Node node = GetNode(key);
            return node != null;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Head: ");
            Node cur = this.head;
            while (cur != null)
            {
                builder.Append($"{cur.key}:{cur.value} =>");
                cur = cur.next;
            }
            builder.Append("null ");
            return builder.ToString();
        }

        public void Add(Key key, Value value)
        {
            Node? node = GetNode(key);
            if (node != null)
                node.value = value;
            else
            {
                this.head = new Node(key, value, this.head);
                N++;
            }
        }

        public void Remove(Key key)
        {
            if (!Contains(key))
                throw new ArgumentException("沒有此Key");

            if (key.Equals(this.head.key))
            {
                this.head = this.head.next;
                N--;
            }
            else
            {
                Node pre = this.head;
                Node cur = this.head.next;
                while (cur != null)
                {
                    if (key.Equals(cur.key))
                        break;
                    pre = cur;
                    cur = cur.next;
                }
                if (cur != null)
                {
                    pre.next = pre.next.next;
                    N--;
                }
            }
        }

        public Value Get(Key key)
        {
            Node node = GetNode(key);

            if( node == null )
                throw new ArgumentException("沒有此Key");

            return node.value;
        }

        public void Set(Key key, Value value)
        {
            Node node = GetNode(key);

            if (node == null)
                throw new ArgumentException("沒有此Key");

            node.value = value;
        }
       
    }
}
