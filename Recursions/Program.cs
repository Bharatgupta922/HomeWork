using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursions // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //Backtracking.nQueenProblem(8);
            //RatNMaze.solve();
            SudokuSolver.solve();


        }

        private static int GetInput()
        {
            Console.WriteLine("Input the string ");
            return Convert.ToInt32(Console.ReadLine());

        }
    }
}
