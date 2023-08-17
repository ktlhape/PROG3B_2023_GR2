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
            cities.AddLast("Sandton");
            cities.AddLast("Joburg");

            DisplayCities(cities);
            //Display all the cities

            //Add Benoni in the first position
            //Add Midrand after Brooklyn
            //Add Cape Town before Joburg

            //Display all cities
        }

        private static void DisplayCities(LinkedList<string> cities)
        {
            throw new NotImplementedException();
        }
    }
}
