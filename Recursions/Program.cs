using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursions // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //int input = GetInput();
            Console.WriteLine($"Decimal {9} to binary {ConvertForms.DecimalToBin(11)}");
            
        }

        private static int GetInput()
        {
            Console.WriteLine("Input the string ");
            return Convert.ToInt32(Console.ReadLine());

        }
    }
}
