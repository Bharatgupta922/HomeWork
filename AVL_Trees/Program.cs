using System;
using System.Collections.Generic;
using System.Linq;

namespace AVL_Trees // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public static void Main(string[] args)
        {
            HeightBalancedTree tree = new HeightBalancedTree();
            tree.Insert(new TreeNode(3));
            tree.Insert(new TreeNode(5));
            tree.Insert(new TreeNode(8));
            tree.Insert(new TreeNode(10));

            





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
