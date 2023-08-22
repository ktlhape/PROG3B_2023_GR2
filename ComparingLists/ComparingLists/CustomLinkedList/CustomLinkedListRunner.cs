using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingLists.CustomLinkedList
{
    internal class CustomLinkedListRunner
    {
        static void Main(string[] args)
        {
            MyLinkedList numbers = new MyLinkedList();
            numbers.AddToFirst(7);
            numbers.AddToFirst(2);
            numbers.AddToLast(3);
            numbers.AddToFirst(15);
            numbers.AddToLast(21);
            numbers.Display();
            Console.Read();
        }
    }
}
