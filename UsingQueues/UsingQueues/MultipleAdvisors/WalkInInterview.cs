using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.MultipleAdvisors
{
    public class WalkInInterview
    {
        public DateTime InterviewTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Student Student { get; set; }
        public string? Advisor { get; set; }
        public int Id { get; set; }
    }
}
