using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingLists.Sorted_List
{
    internal class SortedListRunner
    {
        static void Main(string[] args)
        {
            #region numbersList
            SortedList<int, string> numbers = new
                SortedList<int, string>();

            numbers.Add(7, "Seven");
            numbers.Add(1, "One");
            numbers.Add(12, "Twelve");
            numbers.Add(5, "Five");
            numbers.Add(4, "Four");

            //Display all the elements
            //DisplayItems(numbers);
            numbers.Remove(1);
            numbers.RemoveAt(2);
            //remove element at index 2 (7)
            //DisplayItems(numbers);
            //4,5,12

            #endregion

            /*Create a sorted list to store departments 
             * with a list of employees per department.
             
             you can use IT, HR, FINANCE, etc */
            SortedList<string, List<string>> departments =
                new SortedList<string, List<string>>();

            departments.Add("IT", new List<string>()
            { "Kabelo","Roger","Michael","Tiger"});

            departments.Add("HR", new List<string>()
            { "Thabo","Jessica","Carol"});

            departments.Add("FINANCE", new List<string>()
            { "James","Lesego","David","Serena","Lerato"});

            //Display department data

            foreach (KeyValuePair<string,List<string>> dep in departments)
            {
                Console.Write(dep.Key);
                foreach (string employees in dep.Value)
                {
                    Console.WriteLine($"\t{employees}");
                }
                Console.WriteLine();
            }
        }

        private static void DisplayItems(SortedList<int, string> numbers)
        {
            foreach (KeyValuePair<int, string> num in numbers)
            {
                Console.WriteLine(num.Key + " - " + num.Value);
            }
            Console.WriteLine("===========================");
        }
    }
}
