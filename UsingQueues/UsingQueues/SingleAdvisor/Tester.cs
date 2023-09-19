using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.SingleAdvisor
{
    public class Tester
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            InterviewCenter center = new();
            center.Interview("ST1000");
            center.Interview("ST1256");
            center.Interview("ST5234");
            center.Interview("ST2391");
            center.Interview("ST8971");

            while (center.GetCount() > 0)
            {
                WalkInInterview interview = center.AttendToStudent("Jessica");
                Print($"Interview # {interview.Id} for Student ({interview.StudentId})" +
                    $" is attended by {interview.Advisor}");
                //Assume the interview takes 10 sec
                Thread.Sleep(rdn.Next(5000,10000));
                center.EndInterview(interview);

                Print($"Interview # {interview.Id} with Student ({interview.StudentId})" +
                    $" has ended by {interview.Advisor} at {interview.EndTime.ToString("HH:mm:ss")}\n");

            }
            Console.Read();
        }

        static void Print(string str)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] - {str}");
          
        }

    }
}
