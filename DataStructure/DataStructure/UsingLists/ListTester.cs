using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.UsingLists
{
    public class ListTester
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() 
            { 2,4,6,9,21};
            numbers.Add(7);
            numbers.Insert(2, 5);
            DisplayElements(numbers);
            numbers.Insert(0, 1);
            DisplayElements(numbers);
            numbers.RemoveAt(numbers.Count - 2);

            DisplayElements(numbers);
            int x = 3;
            Console.WriteLine($"Check For {x}: " + CheckForNumber(x,numbers));
            Console.WriteLine($"Sum of Evens: {SumOfEven(numbers)}" );
            AverageOfOdd(numbers);
            MultiplesOfThree(numbers);
            Console.WriteLine(CheckNumber(2));
            Console.Read();
        }
        /// <summary>
        /// Display All the elements in the list
        /// </summary>
        /// <param name="numbers"></param>
        static void DisplayElements(List<int> numbers)
        {
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n///////////////////////\n");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="ls"></param>
        /// <returns></returns>
        static bool CheckForNumber(int x, List<int> ls)
        {
            return ls.Contains(x);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ls"></param>
        /// <returns></returns>
        static int SumOfEven(List<int> ls)
        {
            int sum = 0;
            foreach (int n in ls)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }
            return sum;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ls"></param>
        static void AverageOfOdd(List<int> ls)
        {
            int sum = 0;
            int totalNum = 0;
            float average = 0;

            foreach (int n in ls)
            {
                if (n % 2 != 0)
                {
                    sum += n;
                    totalNum++;
                }
            }
            average = sum / totalNum;
            Console.WriteLine("Average: " + average);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ls"></param>
        static void MultiplesOfThree(List<int> ls) 
        {
            Console.WriteLine("Multiples of Three\n");
            foreach (int n in ls)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(n);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static string CheckNumber(int n)
        {
            return  n % 2 == 0 ? "Even" :
               n % 3 == 0 ? "Multiple of 3" : "Odd"; 
        }


    }
}
