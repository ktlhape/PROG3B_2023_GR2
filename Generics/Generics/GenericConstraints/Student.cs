using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Firstname { get; set; }

        public Student(int studentId, string firstname)
        {
            StudentId = studentId;
            Firstname = firstname;
        }

        public override string ToString()
        {
            return $"({StudentId}) - {Firstname}";
        }
    }
}
