using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 資料結構
{
    public class LinkedList2<E>
    {
        private class Node
        {
            public E e;
            public Node next;

            public Node(E e, Node next)
            {
                this.e = e;
                this.next = next;
            }

            public Node(E e):this(e, null)
            {

            }

            public override string ToString()
            {
                return e.ToString();
            }
        }

        private int N;
        private Node? head;
        private Node? tail;

        public LinkedList2()
        {
            this.N = 0;
            this.head = null;
            this.tail = null;
        }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        public void AddLast(E e)
        {
            if(N==0)
            {
                Node node = new Node(e);
                this.head = node;
                this.tail = node;
            }
            else
            {
                Node node = new Node(e);
                this.tail.next = node;
                this.tail = node;
            }
            N++;
        }

        public E RemoveFirst()
        {
            if (this.N == 0)
                throw new ArgumentException("空鏈表");
            E remove;
            if (N == 1)
            {
                remove = this.head.e;
                this.head = null;
                this.tail = null;
            }
            else
            {
                remove = this.head.e;
                this.head = this.head.next;
            }
            N--;
            return remove;
        }

        public E GetFirst()
        {
            if (this.N == 0)
                throw new ArgumentException("空鏈表");
            return this.head.e;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Head ");
            Node cur = this.head;
            while (cur != null)
            {
                builder.Append($"{cur} =>");
                cur = cur.next;
            }
            builder.Append("null Tail");
            return builder.ToString();
        }
    }
}
