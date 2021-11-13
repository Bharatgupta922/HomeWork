using System;
using System.Collections.Generic;
using System.Linq;

namespace Tree // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(10);
           BinarySearchTree bst = new BinarySearchTree();
            bst.InsertNode(root , new TreeNode(4));
            bst.InsertNode(root, new TreeNode(5));
            bst.InsertNode(root, new TreeNode(19));
            bst.InsertNode(root, new TreeNode(14));
            bst.InsertNode(root, new TreeNode(13));
            bst.inOrder(root);
            Console.WriteLine();
            bst.preOrder(root);
            Console.WriteLine();
            bst.postOrder(root);
            Console.WriteLine();

        }

        private static int GetInput()
        {
            Console.WriteLine("Input the string ");
            return Convert.ToInt32(Console.ReadLine());

        }
    }
}
