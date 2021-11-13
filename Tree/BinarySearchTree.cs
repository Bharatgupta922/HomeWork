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

        public int Height(TreeNode root)
        {
            if (root is null) return 0;
            return Math.Max(Height(root.left), Height(root.right)) + 1;    
        }

        public TreeNode Search(TreeNode root , int data)
        {
            if (root is null) return null;
            if (root.data == data) return root;
            else if(root.data > data)return Search(root.left, data);
            else return Search(root.right, data);
        }

        public int countNodes(TreeNode root)
        {
            if (root is null) return 0;
            return countNodes(root.left) + countNodes(root.right) + 1;
        }

        public int CountLeaves(TreeNode root)
        {
            if (root is null) return 0;
            if(root.left is null && root.right is null) return 1;
            return CountLeaves(root.left) + CountLeaves(root.right);
        }
        

    }
}
