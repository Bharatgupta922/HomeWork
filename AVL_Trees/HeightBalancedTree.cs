using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Trees
{
    public class HeightBalancedTree
    {
        private TreeNode _root { get; set; }

        public HeightBalancedTree()
        {
            _root = null;
        }

        public void Insert(TreeNode node)
        {
            _root = InsertNode(_root, node);
        }

        private TreeNode InsertNode(TreeNode root, TreeNode node)
        {
            // Insert The Node At The Leaf Level
            if (root is null)
                root = node;
            else if (root.data > node.data)
                root.left = InsertNode(root.left, node);
            else if (root.data < node.data)
                root.right = InsertNode(root.right, node);
            else
                throw new Exception("Duplicate Data Values Are Not Allowed");


            // Find The Balance Of This 'root'
            int balance = CalHeight(root.left) - CalHeight(root.right) ;

            
            if(balance > 1 && node.data < root.left.data) // Left Left case
            {
                // Right Rotation 
                root = RightRotation(root);
            }
            if (balance > 1 && node.data > root.left.data) // Left Right case
            {
                //Left Rotation
                root.left = LeftRotation(root.left);
                // Right Rotation 
                root = RightRotation(root);
            }
            if (balance < -1 && node.data > root.right.data) // Right Right case
            {
                //Left Rotation
                root = LeftRotation(root);
            }
            if (balance < -1 && node.data < root.right.data) // Right Left case
            {
                //Right Rotaion
                root.right = RightRotation(root.right);
                //Left Rotation
                root = LeftRotation(root);
            }

            return root;
        }

        private TreeNode LeftRotation(TreeNode root)
        {
            // Root.Right Is Going To Be The New Root
            var newRoot = root.right;

            // Original Root.Right Will Now Hold root.Right.Left SubTree
            root.right = newRoot.left;

            // Move Original Root to The Left Of New Root
            newRoot.left = root;

            return newRoot;
        }

        private TreeNode RightRotation(TreeNode root)
        {
            // Root.Left Is Going To Be The New Root
            var newRoot = root.left;

            // Original Root.Left Will Now Hold root.Left.Right SubTree
            root.left = newRoot.right;

            // Move Original Root to The Right Of New Root
            newRoot.right = root;

            return newRoot;
        }


        private int CalHeight(TreeNode root)
        {
            if (root is null) return 0;
            return Math.Max(CalHeight(root.left), CalHeight(root.right)) + 1;
        }

        public void Delete(TreeNode node)
        {
            _root = DeleteNode(_root, node);
        }

        private TreeNode DeleteNode(TreeNode root, TreeNode node)
        {
            if (root.data > node.data) return DeleteNode(root.left, node);
            else if (root.data < node.data) return DeleteNode(root.right, node);
            else
            {
                if (root.left is null && root.right is null)
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

                    root.left = DeleteNode(root.left, p);
                }
            }

            if (root is null) return root;
            int balance = GetBalance(root);
            int leftBalance = GetBalance(root.left);
            int rightBalance = GetBalance(root.right);

            if (balance > 1 && leftBalance >= 0)//left left case
            {
                //right rotation
                root = RightRotation(root);
            }

            if (balance > 1 && leftBalance < 0) //left right case
            {
                //left rotation 
                root.left = LeftRotation(root.left);
                //right rotation
                root = RightRotation(root);
            }

            if (balance < -1 && rightBalance <= 0)//right right case 
            {
                //left rotation 
                root = LeftRotation(root);
            }

            if (balance < -1 && rightBalance > 0)//right left case
            {
                //right rotation 
                root.right = RightRotation(root.right);
                //left rotation 
                root = LeftRotation(root);
            }

            return root;
        }

        private int GetBalance(TreeNode root)
        {
            return CalHeight(root.left) - CalHeight(root.right);
        }

        private TreeNode FindMaxInLeftSubtree(TreeNode root)
        {
            TreeNode p = root.left;
            while (p.right is not null)
                p = p.right;
            return p;
        }


    }
}
