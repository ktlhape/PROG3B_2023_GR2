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
            // int[] numbers = new int[99999];
            //create a list to store student objects
            List<Student> students = new List<Student>()
            {
                new Student("Kelvin","Smith",21),
                new Student("Roger","Federer",18),
                new Student("Michael","Jordan",18),
                new Student("Serena","Williams",23),
                new Student("Tiger","Woods",20)
            };

            /*Create a method that will sort the 
             * students by age*/
            Console.WriteLine("=====Before Sort=====\n");
            DisplayStudents(students);
            SortStudents(students);
            Console.WriteLine("\n=====After sort======");
            DisplayStudents(students);

            List<int> numbers = new List<int>();
            Random rdn = new Random();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rdn.Next(1,1500));
            }
            //Console.WriteLine("=====Before Sort=====");
            //DisplayElements(numbers);
            //BubbleSort(numbers);
            //SelectionSort(numbers);
            //InsertionSort(numbers);
            //Console.WriteLine("\n=====After Sort=====");
            //DisplayElements(numbers);
            Console.Read();
        }
        private static void DisplayStudents(List<Student> students)
        {
            foreach (Student st in students)
            {
                Console.WriteLine(st.ToString());
            }
        }
        private static void SortStudents(List<Student> stList)
        {
            for (int i = 0; i < stList.Count - 1; i++)
            {
                for (int j = (i + 1); j < stList.Count; j++)
                {
                    if (stList[i].Age > stList[j].Age)
                    {
                        Student temp = stList[i];
                        stList[i] = stList[j];
                        stList[j] = temp;
                    }
                }
            }
        }

        private static void InsertionSort(int[] ar)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            for (int i = 0; i < ar.Length  - 1; i++)
            {
                for (int j = (i + 1); j > 0; j--)
                {
                    if (ar[j - 1] < ar[j])
                    {
                        int temp = ar[j - 1];
                        ar[j - 1] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            Console.WriteLine($"Insertion Sort: {stw.ElapsedMilliseconds}");
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
        private static void DisplayElements(List<int> numbers)
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

        private static void BubbleSort(List<int> ls)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            for (int x = 0; x < ls.Count - 1; x++)
            {
                for (int j = (x + 1); j < ls.Count; j++)
                {
                    if (ls[j] < ls[x])
                    {
                        int temp = ls[j];
                        ls[j] = ls[x];
                        ls[x] = temp;
                    }
                }
            }
            Console.WriteLine($"Bubble Sort: {stw.ElapsedMilliseconds}");
        }
    }
}
