using BinarySearchTree;
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
        
        public void LevelOrderTraversal(TreeNode root)
        {
            if (root is null) return;
            CircularCountQueue<TreeNode> queue = new CircularCountQueue<TreeNode>(20);
            queue.Add(root);
            while(queue.IsEmpty() == false)
            {
                TreeNode p = queue.Remove();
                Console.Write(p.data + " ");
                if(p.left is not null)queue.Add(p.left);
                if(p.right is not null)queue.Add(p.right);
            }
        }

        public int Width(TreeNode root)
        {
            if (root is null) return 0;
            CircularCountQueue<TreeNode> queue = new CircularCountQueue<TreeNode>(20);
            queue.Add(root);
            queue.Add(null);
            int count = 0, max_count = 0; 

            while (queue.IsEmpty() == false)
            {
                count = 0; 
                while(queue.Peek() is not null)
                {

                TreeNode p = queue.Remove();
                    count++;
                if (p.left is not null) queue.Add(p.left);
                if (p.right is not null) queue.Add(p.right);
                }
                queue.Add(null);

                max_count = Math.Max(count , max_count);
                
                //removing the last null
                _ = queue.Remove();
            }

            return max_count;
        }


        public TreeNode DeleteANode(TreeNode root , TreeNode node)
        {
            if (root.data > node.data) return DeleteANode(root.left, node);
            else if (root.data < node.data)return DeleteANode(root.right, node);
            else
            {
                if(root.left is null && root.right is null)
                {
                    root = null;
                }
                else if (root.left is null)
                {
                    root = root.right;
                }
                else if (root.right is null)
                {
                    root = root.left;
                }
                else
                {
                    TreeNode p = FindMaxInLeftSubtree(root);

                    root.data = p.data;

                    root.left = DeleteANode(root.left , p);

                }
            }
            return root;
        }

        public TreeNode FindMaxInLeftSubtree(TreeNode root)
        {
            TreeNode p = root.left;

            while(p.right is not null)
                p = p.right;
            
            return p;
        }

        public int CAlSum(TreeNode root)
        {
            if (root is null) return 0;
            return CAlSum(root.left) + CAlSum(root.right) + root.data;
        }

        public void PrintLeafNode(TreeNode root , Action<TreeNode> ProcessNode)
        {
            if (root is null) return;

            PrintLeafNode(root.left, ProcessNode);

            if (root.left is null && root.right is null)
                ProcessNode(root);

            PrintLeafNode(root.right, ProcessNode);

        }

        public void PrintNonLeafNode(TreeNode root , Action<TreeNode> processNode)
        {
            if (root is null) return;
            PrintNonLeafNode(root.left, processNode);
            if (root.left is not null && root.right is not null)
                processNode(root);
            PrintNonLeafNode(root.right, processNode);
        }


        public TreeNode PrintMirrorOfTree(TreeNode root , Action<TreeNode> ProcessNode)
        {
            if(root != null)
            {
                var left = PrintMirrorOfTree(root.left, ProcessNode);
                var right = PrintMirrorOfTree(root.right, ProcessNode);

                root.right = left;
                root.left = right;
            }
            return root;
        }

        public void LeftViewOfTree(TreeNode root , Action<TreeNode> ProcessNode)
        {
            CircularCountQueue<TreeNode> queue = new CircularCountQueue<TreeNode>(20);
            queue.Add(root);
            queue.Add(null);
            int count = 0, max_width = 0 ;
            while(queue.IsEmpty() != true)
            {
                count = 0;
                while(queue.Peek() is not null)
                {
                    TreeNode p = queue.Remove();
                    
                    if (p.left is not null) queue.Add(p.left);
                    if (p.right is not null) queue.Add(p.right);
                }
                queue.Add(null);

                max_width = Math.Max(count, max_width);

                queue.Remove();
                ProcessNode(queue.Peek());
            }

        }

    }
}
