using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //int input = GetInput();
            Console.WriteLine($"the sum of first {10} natural numbers is {AnotherSeries.Series_10(2)}");
            //AnotherSeries.Series_1(5);

        }

        private static int GetInput()
        {
            Console.WriteLine("Input the string ");
            return Convert.ToInt32(Console.ReadLine());

        }
    }
}
