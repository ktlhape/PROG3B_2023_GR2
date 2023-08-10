using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[99999];
            Random rdn = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rdn.Next(1,1500);
            }

            //Console.WriteLine("=====Before Sort=====");
            //DisplayElements(numbers);

            BubbleSort(numbers);
            SelectionSort(numbers);
            Console.WriteLine("\n=====After Sort=====");
            //DisplayElements(numbers);
            Console.Read();
        }
        private static void SelectionSort(int[] ar)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            int minIndex;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                minIndex = i;
                for (int x   = (i + 1); x < ar.Length; x++)
                {
                    if (ar[x] < ar[i])
                    {
                        minIndex = x;
                    }
                }
                int temp = ar[i];
                ar[i] = ar[minIndex];
                ar[minIndex] = temp;

            }
            Console.WriteLine($"Selection Sort: {stw.ElapsedMilliseconds}");
        }

        private static void DisplayElements(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        private static void BubbleSort(int[] ar)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            for (int x = 0; x < ar.Length - 1; x++)
            {
                for (int j = (x + 1); j < ar.Length; j++)
                {
                    if (ar[j] < ar[x])
                    {
                        int temp = ar[j];
                        ar[j] = ar[x];
                        ar[x] = temp;
                    }
                }
            }
            Console.WriteLine($"Bubble Sort: {stw.ElapsedMilliseconds}");
        }
    }
}
