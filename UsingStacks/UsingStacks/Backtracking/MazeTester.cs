using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStacks.Backtracking
{
    internal class MazeTester
    {
       static int[,] maze = new int[,]{
        { 1,1,0,0},
        { 1,0,0,0},
        { 1,0,1,0},
        { 0,0,1,1}};
        /*create a 2D array "path" that has the same
         * number of rows and columns as the maze*/
        static int[,] path = new int[4, 4];
        static void Main(string[] args)
        {
            FindPath(0, 0, 4);
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    if (path[row,col] == 1)
                    {
                        Console.WriteLine($"({row}, {col})");
                    }
                }
            }
            Console.Read();
        }
        static int FindPath(int row, int col, int size)
        {
            if (row == size - 1 && col == size - 1) return 1;
            if (maze[row,col] == 1)
            {
                path[row, col] = 1;
                if (FindPath(row, col + 1, size) == 1) return 1;
                if (FindPath(row + 1, col, size) == 1) return 1;

                path[row, col] = 0;
            }
            return 0;
      
        }
    }
}
