using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.MultipleAdvisors
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Student(string id, string firstname, string lastname)
            => (StudentId, Firstname, Lastname) = (id, firstname, lastname);
    }
}
