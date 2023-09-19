using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStacks.Backtracking
{
    internal class Tester
    {
        static int size = 4;
        static int[,] maze = new int[,]{
        { 1,1,0,0},
        { 1,0,0,0},
        { 1,1,1,0},
        { 0,0,1,1}};
        static int[,] path = new int[size, size];
        static void Main(string[] args)
        {
            ShowPath();
            Console.Read();
        }
        static bool IsValidPath(int row, int col)
        {
            return (row >= 0 && row < size && col >= 0 && col < size
                 && maze[row, col] == 1);
        }
        static bool SolveMaze(int row, int col)
        {
            if (row == size - 1 && col == size - 1)
            {
                path[row, col] = 1;
                return true;
            }
            if(IsValidPath(row, col) == true) //0,0
            {
                path[row, col] = 1;
                //0, 1
                if (SolveMaze(row, col + 1) == true) // move to the right
                    return true;
                if (SolveMaze(row + 1, col) == true)
                    return true;
                path[row, col] = 0;
                return false;
            }
            return false;
        }

        static void ShowPath()
        {
            if (SolveMaze(0,0) == false)
            {
                Console.WriteLine("No path");
            }
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                   
                    if (path[row, col] == 1)
                    {
                        Console.WriteLine($"({row},{col})");
                    }

                }
            }
        }
    }
}
