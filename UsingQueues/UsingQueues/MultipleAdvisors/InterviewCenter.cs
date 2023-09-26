using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.MultipleAdvisors
{
    public class InterviewCenter
    {
        private int _count = 0;
        public ConcurrentQueue<WalkInInterview>? Interviews { get; set; }

        public InterviewCenter()
        {
            Interviews = new();
        }
        public void Interview(Student st)
        {
            WalkInInterview interview = new WalkInInterview()
            {
                InterviewTime = DateTime.Now,
                Student = st,
                Id = ++_count
            };
            Interviews.Enqueue(interview);
        }
        public WalkInInterview AttendToStudent(string advisor)
        {
            if (Interviews.Count > 0 && Interviews.TryDequeue(out WalkInInterview interview))
            {
                interview.Advisor = advisor;
                interview.StartTime = DateTime.Now;
                return interview;
            }
            return null;
        }
        public void EndInterview(WalkInInterview interview)
        {
            interview.EndTime = DateTime.Now;
        }
        public int GetCount() =>
        Interviews.Count;
    }
}
