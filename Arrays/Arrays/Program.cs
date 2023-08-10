using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Multidimensional
            int[,] ar = new int[5, 6];
            int num = 2;
            for (int row = 0; row < ar.GetLength(0); row++)
            {
                for (int col = 0; col < ar.GetLength(1); col++)
                {
                    ar[row, col] = num;
                    num += 2;

                }
            }


            for (int row = 0; row < ar.GetLength(0); row++)
            {
                for (int col = 0; col < ar.GetLength(1); col++)
                {
                    Console.Write(ar[row,col] + " ");
                }
                Console.WriteLine();
            }

            #endregion

            Console.WriteLine("Jagged Arrays");
            string[] names = new string[] { "David","Kabelo"};
            string[] name2 = new string[] { "Carol","Kabelo","James"};

            string[][] jaggedNames = new string[][] { names,name2};

            //Kabelo, James, Carol

            string[] h_Kabelo = new string[] { "Tennis","Soccer"};
            string[] h_James = new string[] { "Soccer","Hockey","Reading"};
            string[] h_Carol = new string[3];

            string[][] jaggedHobbies = new string[4][];

            jaggedHobbies[0] = h_Kabelo;
            jaggedHobbies[1] = h_James;
            jaggedHobbies[2] = h_Carol;
            jaggedHobbies[3] = new string[] {"Swimming","Rugby","Chess" };

            //Carol is interested in Chess, Tennis, Hockey
            jaggedHobbies[2][0] = "Chess";
            jaggedHobbies[2][1] = "Tennis";
            jaggedHobbies[2][2] = "Hockey";

            jaggedHobbies[1][2] = "Rugby";//overide Reading with Rugby




            Console.Read();

        


        }
    }
}
