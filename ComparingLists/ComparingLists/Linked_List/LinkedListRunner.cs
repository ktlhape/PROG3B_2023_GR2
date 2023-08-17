using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingLists.Linked_List
{
    internal class LinkedListRunner
    {
        static void Main(string[] args)
        {
            LinkedList<string> cities = 
                new LinkedList<string>();

            cities.AddLast("Pretoria");
            cities.AddLast("Brooklyn");
            cities.AddFirst("Sandton");
            cities.AddLast("Joburg");

            DisplayCities(cities);
            //Display all the cities

            //Add Benoni in the first position
            cities.AddFirst("Benoni");

            //Add Midrand after Brooklyn
            cities.AddAfter(cities.Find("Brooklyn"), "Midrand");
            //Add Cape Town before Joburg
            LinkedListNode<string> findJoburg = cities.Find("Joburg");
            cities.AddBefore(findJoburg, "Cape Town");
            //Display all cities
            DisplayCities(cities);
        }

        private static void DisplayCities(LinkedList<string> cities)
        {
            Console.WriteLine("=========================");
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
