using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishExpressions
{
    class convertPolish
    {
        static int i = 0;
        public static string InfixToPostfix(string exprr)
        {
            char ch = exprr[i++];
            if (ch == '(')
            {
                var leftOperand = InfixToPostfix(exprr);
                var op = InfixToPostfix(exprr);
                var rightOperand = InfixToPostfix(exprr);
                _ = InfixToPostfix(exprr);
                return leftOperand  + rightOperand + op;
            }
            else if(ch==')'  ||  isOperator(ch) || char.IsDigit(ch))
            {
                return "" + ch;
            }
            else
            {
                throw new Exception("Invalid expression ");
            }
            
        }
        public static bool isOperator(char ch)
        {
            return (ch == '+' || ch == '-' || ch == '*' || ch == '/');
        }
    }
        class EvalPolish
    {

        
    }
}
