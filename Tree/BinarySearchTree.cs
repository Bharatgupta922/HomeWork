using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public  class BinarySearchTree
    {
        public TreeNode InsertNode(TreeNode root, TreeNode node)
        {

            if(root == null)
            {
                root = node;
            }
            else if (root.data > node.data)
            {
                root.left = InsertNode(root.left , node);
            }
            else
            {
                root.right = InsertNode(root.right,node);
            }

            return root;
        }
        
        public void preOrder(TreeNode root)
        {
            if (root == null) return;
            Console.Write($"{root.data} ,");
            preOrder(root.left);
            preOrder(root.right);
        }
        public void inOrder(TreeNode root)
        {
            if (root == null) return;
            inOrder(root.left);
            Console.Write($"{root.data} ,");
            inOrder(root.right);
        }
        public void postOrder(TreeNode root)
        {
            if (root == null) return;
            postOrder(root.left);
            postOrder(root.right);
            Console.Write($"{root.data} ,");
        }



    }
}
