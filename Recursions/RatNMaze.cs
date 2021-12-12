using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    public static class RatNMaze
    {
        public static bool isSafe(int[,] maze , int i , int j , int x , int y , int rows , int cols , bool[,] visited)
        {
            return i >= 0 && i < rows && j >= 0 && j < cols && maze[i, j] == 1 && (!visited[i, j]);
        }
        public static int solveRatNMaze(int [,] maze , int i, int j , int x, int y , int rows , int cols , bool [,] visited)
        {
            if(i==x && j == y)
            {
                return 1;
            }
            if (isSafe(maze, i, j, x, y, rows, cols, visited) == false)
            {
                return 100000;
            }
            visited[i, j] = true;
            int up = solveRatNMaze(maze, i - 1, j, x, y, rows, cols, visited) + 1;
            int down = solveRatNMaze(maze, i + 1, j, x, y, rows, cols, visited) + 1;
            int left = solveRatNMaze(maze, i , j -1, x, y, rows, cols, visited) + 1;
            int right = solveRatNMaze(maze, i, j + 1, x, y, rows, cols, visited) + 1;
            visited[i, j] = false;

            return Math.Min(Math.Min(up, down), Math.Min(left,right));
        }
        public static void solve()
        {
            bool[,] visited = new bool[,] { { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false } };
           int[,] maze = new int[,] { { 1, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1 } };
            int result = solveRatNMaze(maze, 0, 0, 4, 4, 5, 5, visited);
            if(result >= 100000)
                Console.WriteLine("not possible to pass");
            else
                Console.WriteLine($" the shortest path is {result}");

        }

    }
}
