using System;

namespace PolishExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = GetInput();
            string output = convertPolish.InfixToPostfix(input);
            Console.WriteLine($"{input} converted into {output} ");
        }

        private static string GetInput()
        {
            Console.WriteLine($"Give Your input expression");
            return Console.ReadLine();
        }
    }
}
