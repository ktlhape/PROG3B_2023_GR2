using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericLinkedList
{
    internal class LinkedListTester
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> names = new MyLinkedList<string>();

            names.AddToFirst("Maria");
            names.AddToFirst("Serena");

            MyLinkedList<int> numbers = new MyLinkedList<int>();

            numbers.AddToFirst(5);
            numbers.AddToFirst(6);


            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
