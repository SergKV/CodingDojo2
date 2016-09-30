using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo2
{
    public class Stack<T>
    {
        public class Node
        {

            private T _data;
            private Node _nextNode;

            public Node(T t)
            {
                _nextNode = null;
                _data = t;
            }

            public Node NextNode
            {
                get { return _nextNode; }
                set { _nextNode = value; }
            }

            public T Value
            {
                get { return _data; }
                set { _data = value; }
            }
        }

        private Node head = null;

        public Stack()
        {
            head = null;
        }

        public void Push(T t)
        {
            Node x = new Node(t);
            if (head != null)
            {
                x.NextNode = head;
            }
            head = x;
        }

        public T Pop()
        {
            Node temp = head;
            head = head.NextNode;
            temp.NextNode = null;
            return temp.Value;
        }


        public T Peek()
        {
            if (head.Value != null)
            {
                return head.Value;
            }
            return head.Value;
        }
    }
}
