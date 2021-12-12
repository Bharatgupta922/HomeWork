using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// this is yet to be checked 
/// </summary>
namespace Recursions
{
    public static class RatNMazePathDirection
    {

        public static bool isSafe(int[,] maze, int i, int j, int x, int y, int rows, int cols, bool[,] visited)
        {
            return i >= 0 && i < rows && j >= 0 && j < cols && maze[i, j] == 1 && (!visited[i, j]);
        }
        public static bool printPath(int[,] maze, int i, int j, int x, int y, int rows, int cols, bool[,] visited ,string str, List<string> vec)
        {
            if (i == x && j == y)
            {
                vec.Add(str);
                return true;
            }

            if (isSafe(maze, i, j, x, y, rows, cols, visited) == false)
            {
                return false;
            }

            visited[i, j] = true;
            bool up = printPath(maze, i - 1, j, x, y, rows, cols, visited,str+'U' , vec) ;
            bool down = printPath(maze, i + 1, j, x, y, rows, cols, visited, str + 'D', vec);
            bool left = printPath(maze, i, j - 1, x, y, rows, cols, visited, str + 'L', vec);
            bool right = printPath(maze, i, j + 1, x, y, rows, cols, visited, str + 'R', vec);
            visited[i, j] = false;

            return up||right||down||left;
        }
        public static List<string> solveUtil(int[,] maze , int i , int j , int x , int y , int rows , int cols ,bool [,] visited , string str , List<string> vec)
        {
            bool success = printPath(maze, i, j, x, y, rows, cols, visited, str, vec);
            if (success)
            {
                vec.Sort();
            }
            return vec;
        }
        public static void solve()
        {
            bool[,] visited = new bool[,] { { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false } };
            int[,] maze = new int[,] { { 1, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1 } };
            List<string> vec = new List<string>();

            vec = solveUtil(maze, 0, 0, 4, 4, 5, 5, visited, "" , vec);
            if(vec.Count == 0)
            {
                Console.WriteLine("Zero Paths ");
            }
            else
            {
                foreach(var x in vec)
                {
                    Console.WriteLine($"{x}");
                }
            }


        }
    }
}
