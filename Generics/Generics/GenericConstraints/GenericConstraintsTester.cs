using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints
{
    internal class GenericConstraintsTester
    {
        static void Main(string[] args)
        {
            MyLinkedList<Student> students = new MyLinkedList<Student>();
            students.AddToFirst(new Student(1, "Kabelo"));
            students.AddToFirst(new Student(2, "Roger"));
            students.AddToFirst(new Student(3, "Michael"));
            students.AddToFirst(new Student(4, "Lesego"));

            foreach (Student st in students)
            {
                Console.WriteLine(st.ToString());
            }
        }
    }
}
