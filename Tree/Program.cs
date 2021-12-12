using System;
using System.Collections.Generic;
using System.Linq;

namespace Tree // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(21);
           BinarySearchTree bst = new BinarySearchTree();
            bst.InsertNode(root , new TreeNode(5));
            bst.InsertNode(root, new TreeNode(27));
            //bst.InsertNode(root, new TreeNode(4));
            //bst.InsertNode(root, new TreeNode(9));
            //bst.InsertNode(root, new TreeNode(6));
            //bst.InsertNode(root, new TreeNode(11));
            //bst.InsertNode(root, new TreeNode(10));
            //bst.InsertNode(root, new TreeNode(30));
            //bst.InsertNode(root, new TreeNode(28));

            //bst.inOrder(root);
            //Console.WriteLine();
            //bst.preOrder(root);
            //Console.WriteLine();
            //bst.postOrder(root);
            //Console.WriteLine();
            //bst.LevelOrderTraversal(root);
            //bst.DeleteANode(root, bst.Search(root , 11));
            //Console.WriteLine();
            //bst.LevelOrderTraversal(root);

            //Console.WriteLine();
            //bst.PrintLeafNode(root, PrintNodeData);
            //bst.inOrder(root);
            //Console.WriteLine();
            //root = bst.PrintMirrorOfTree(root, PrintNodeData);
            //bst.inOrder(root);
            Console.WriteLine(bst.Width(root));
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
