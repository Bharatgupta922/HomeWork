using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionTree // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public static void Main(string[] args)
        {
            ExpressionTree tree = new ExpressionTree("((1+2)*(3+5))");
            Console.WriteLine(tree.Evaluate());
        }

        private static int GetInput()
        {
            Console.WriteLine("Input the string ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void PrintNodeData(TreeNode node)
        {
            Console.Write($"{node.data}, ");
        }



    }
}
