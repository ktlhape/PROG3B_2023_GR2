using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints
{
    public class MyLinkedList<T> : IEnumerable<T> where T : Student
    {
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public Node(T value)
            {
                this.Data = value;
            }
        }

        private Node head;
        public void AddToFirst(T value)
        {
            Node newNode = new Node(value);
            if (head is null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                newNode.Previous = null;
                head.Previous = newNode;
                head = newNode;
            }
        }
        public void AddToLast(T value)
        {
            Node newNode = new Node(value);
            if (head is null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                yield return currentNode.Data;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
