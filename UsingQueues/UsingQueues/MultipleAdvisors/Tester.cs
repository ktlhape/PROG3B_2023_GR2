using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQueues.MultipleAdvisors
{
    public class Tester
    {
        //Array of firstnames and lastnames to choose from at random
        static string[] names = { "Mike","Thomas","James","Thabo","Jordan","Harvey","Lesely","Kabelo","Roger","Michael"};
        static string[] lastnames = { "Federer","Jordan","Smith","Ross","Specter","Litt","Pearson"};
        static void Main(string[] args)
        {
            InterviewCenter center = new();
            Parallel.Invoke(
            () => StudentAction(center),
            () => AdvisorAction(center, "Jessica",ConsoleColor.Red),
            () => AdvisorAction(center, "Lungelo", ConsoleColor.Green),
            () => AdvisorAction(center, "Tyler", ConsoleColor.Blue),
            () => AdvisorAction(center, "Mpumi", ConsoleColor.Yellow)
            );//Execute these methods in parallel

            Console.Read();

        }
        /// <summary>
        /// Action to be performed by a student at an Interview Center
        /// </summary>
        /// <param name="center">Interview Center</param>
        static void StudentAction(InterviewCenter center)
        {
            Random rdn = new Random();

            while (true)
            {
                string stId = $"ST{rdn.Next(1000, 9999)}";
                string name = names[rdn.Next(0, names.Length - 1)];
                string lastname = lastnames[rdn.Next(0, lastnames.Length - 1)];

                Student st = new(stId, name, lastname);
                
                center.Interview(st);
                Console.ForegroundColor = ConsoleColor.White;
                Print($"Student {stId} is waiting in a queue");
                Thread.Sleep(rdn.Next(5000, 6000));//Assume the student will wait about 5-6 seconds before being attended
            }
         
        }
        /// <summary>
        /// Action to be performed by a Student Advisor at an Interview Center
        /// </summary>
        /// <param name="center">Interview Center</param>
        /// <param name="advisorName">Student Advisor name to be provided</param>
        /// <param name="color"></param>
        static void AdvisorAction(InterviewCenter center, string advisorName, ConsoleColor color)
        {
            Random rdn = new Random();

            while (true)
            {
                WalkInInterview interview = center.AttendToStudent(advisorName);

                if (interview != null)
                {
                    Console.ForegroundColor = color;
                    Print($"Interview # {interview.Id} with Student ({interview.Student.StudentId} - {interview.Student.Firstname} {interview.Student.Lastname})" +
                                $" is attended by {interview.Advisor}");
                     Thread.Sleep(rdn.Next(3000, 7000)); //Assume the interview takes 3-7 seconds
                    center.EndInterview(interview);

                    Console.ForegroundColor = color;
                    Print($"Interview # {interview.Id} with Student ({interview.Student.StudentId} - {interview.Student.Firstname} {interview.Student.Lastname})" +
                        $" has ended");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(rdn.Next(3000, 5000));//Assume advisor will take 3-5 seconds to leave the interview room
                }
                else
                {
                    Thread.Sleep(2000);
                }

            }
        }
        /// <summary>
        /// Print to console
        /// </summary>
        /// <param name="str">Deatils to be displayed</param>
        static void Print(string str)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] - {str}");

        }
    }
}
