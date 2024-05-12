using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class LinkedList1<E>
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

            public Node(E e):this(e,null)
            {

            }

            public override string ToString()
            {
                return e.ToString();
            }
        }

        private int N;
        private Node head;

        public LinkedList1()
        {
            this.N = 0;
            this.head = null;
        }
        
        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("越界");

            if (index == 0)
                this.head = new Node(e, this.head);
            else
            {
                Node pre = head;
                for (int i = 0; i < index-1; i++)
                {
                    pre = pre.next;
                }
                //Node node = new Node(e);
                //node.next = pre.next;
                //pre.next = node;

                pre.next = new Node(e, pre.next);
            }
            N++;
        }

        public void AddFirst(E e)
        {
            this.Add(0, e);
        }

        public void AddLast(E e)
        {
            this.Add(N,e);
        }

        public bool Contains(E e)
        {
            Node cur = this.head;
            while(cur != null)
            {
                if (e.Equals(cur.e))
                    return true;
                cur = cur.next;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Head: ");
            Node cur = this.head;
            while( cur != null)
            {
                builder.Append($"{cur} =>");
                cur= cur.next; 
            }
            builder.Append("null ");
            return builder.ToString();
        }

        public E RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("越界");

            E remove;
            if(index == 0)
            {
                remove = this.head.e;
                this.head = this.head.next;
            }
            else
            {
                Node pre = this.head;
                for (int i = 0; i < index-1; i++)                
                    pre = pre.next;
                remove = pre.next.e;
                pre.next = pre.next.next;                     
            }
            N--;
            return remove;
        }

        public E RemoveFirst()
        {
            return RemoveAt(0);
        }

        public E RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        public void Remove(E e)
        {
            if (N == 0)
                throw new ArgumentException("空鏈表");

            if (e.Equals(this.head.e))
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
                    if (e.Equals(cur.e))
                        break;
                    pre = cur;
                    cur = cur.next;
                }
                if(cur != null)
                {
                    pre.next = pre.next.next;
                    N--;
                }
            }
        }

        public E Get(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("越界");
            Node cur = this.head;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            return cur.e;
        }

        public E GetFirst()
        {
            return this.Get(0);
        }

        public E GetLast()
        {
            return this.Get(N - 1);
        }

        public void Set(int index, E newE)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("越界");
            Node cur = this.head;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            cur.e = newE;
        }

        public void SetFirst(E e)
        {
            this.Set(0, e);
        }

        public void SetLast(E e)
        {
            this.Set(N - 1, e);
        }
    }
}
