using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreEqual<int>(5, 4));
            Console.WriteLine(AreEqual<double>(5.4,5.4));
            Console.WriteLine(AreEqual<string>("A","a"));
            Console.WriteLine(GetLength<string,int>("Kabelo",5));
            Console.Read();
            
        }

        static bool AreEqual<T>(T x, T y)
        {
            if (x.GetType() == typeof(string))
            {
                //return x.ToString().ToLower().Equals(y.ToString().ToLower());
                return string.Compare(x.ToString(), y.ToString(), true) == 0;

            }
            return x.Equals(y);
        }

        static bool GetLength<T1,T2>(T1 str, T2 length)
        {
            return str.ToString().Length.Equals(length);
        }
       
    }
}
