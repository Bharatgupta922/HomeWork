using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree
{
    public  class ExpressionTree
    {
        private TreeNode _root { get; set; }
        static int i = 0;
        
        public ExpressionTree()
        {
            _root = null;
        }

        public int Evaluate()
        {
            return  EvaluateExpression(_root);
        }

        private int EvaluateExpression(TreeNode root)
        {
            if (isOperator(root.data))
            {
                return Calculate(root.data, EvaluateExpression(root.left), EvaluateExpression(root.right));
            }
            else
            {
                return root.data - '0';
            }
        }

        private int Calculate(char ch, int op1, int op2)
        {
            return ch switch
            {
                '+' => op1 + op2,
                '-' => op2 - op1,
                '*' => op1 * op2,
                '/' => op2 / op1,
                _ => throw new Exception("Invalid operator"),
            };
        }

        public ExpressionTree(string expr)
        {
            i = 0;
            _root = CreateExpressionTree(expr);
        }

        private TreeNode CreateExpressionTree(string expr)
        {
            var ch = expr[i++];

            while(ch == ')')
            {
                ch = expr[i++];
            }

            if (ch == '(')
            {
                var leftSubtree = CreateExpressionTree(expr);
                var newRoot = CreateExpressionTree(expr);
                var rightSubtree = CreateExpressionTree(expr);

                newRoot.left = leftSubtree;
                newRoot.right = rightSubtree;
                return newRoot;
            }
            else if (isOperator(ch) || char.IsDigit(ch))
            {
               return new TreeNode(ch);
            }
            else {
                throw new Exception("Invalid Expression");
            }
        
            
        }
        public static bool isOperator(char ch)
        {
            return (ch == '+' || ch == '-' || ch == '*' || ch == '/');
        }


    }
}
