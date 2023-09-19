using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.SingleAdvisor
{
    public class InterviewCenter
    {
        private int _count = 0;
        public Queue<WalkInInterview>? Interviews { get; set; }

        public InterviewCenter()
        {
            Interviews = new Queue<WalkInInterview>();
        }

        public void Interview(string stId)
        {
            WalkInInterview interview = new WalkInInterview()
            {
                InterviewTime = DateTime.Now,
                StudentId = stId,
                Id = ++_count
            };
            Interviews.Enqueue(interview);
        }
        public WalkInInterview AttendToStudent(string advisor)
        {
            if (Interviews.Count > 0)
            {
                WalkInInterview interview = Interviews.Dequeue();
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
