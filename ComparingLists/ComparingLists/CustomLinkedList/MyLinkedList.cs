using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingLists.CustomLinkedList
{
    public class MyLinkedList
    {
       private Node head;

        public void AddToFirst(int value)
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
        public void AddToLast(int value)
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

        public void Display()
        {
            Node currentNode = head;

        }
    }
}
