using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static  class AnotherSeries
    {

        /// <summary>
        /// Sum Of series, e.g., S = X/1! + X^2/2! + X^3/3! + ...X^N/N!
        /// </summary>
        /// <param name="n"></param>
        public static double Series_11(int n , int x)
        {
            double sum = 0;
            int loop = 1;
            double nume = x;
            int deno = 1;
            while (loop <= n)
            {
                //add the next item 
                sum += (nume/deno);
                /// update the numerator and denominator
                nume = nume * x;
                deno = deno * (loop + 1);
                //increment the loop
                loop++;
            }
            return sum;
        }


        /// <summary>
        ///  Sum Of series, e.g., S = 1/1! + 2/2! + 3/3! + ...N/N! 
        /// </summary>
        /// <param name="n"></param>
        public static double Series_10(int n)
        {
            double sum = 0;
            int loop = 1;
            double term = 1;
            while (loop <= n)
            {
                //add the next item 
                sum += (loop/term);
                term = term * (loop + 1);
                //increment the loop
                loop++;
            }
            return sum;
        }


        /// <summary>
        /// series sum S = F(1) + F(2) + F(3) + ........... + F(N)
        /// </summary>
        /// <param name="n"></param>
        public static double Series_8(int x, int n)
        {
            double sum = 0;
            int loop = 1;
            int term = x;
            int first = 1;
            int second = 1;
            while (loop <= n)
            {
                //add the next item 
                sum += first;
                int third = first + second;
                first = second;
                second = third;
                //increment the loop
                loop++;
            }
            return sum;
        }


        /// <summary>
        /// series sum S = x^1 - x^2 - x^3 - ........ x^n
        /// </summary>
        /// <param name="n"></param>
        public static double Series_7(int x , int n )
        {
            double sum = 0;
            int loop = 1;
            int term = x;
            int sign = -1;
            while (loop <= n)
            {
                //add the next item 
                sum += term;
                //update the term for next component
                term = term * x * sign;
                //increment the loop
                loop++;
            }
            return sum;
        }

        /// <summary>
        /// series sum S = 1/1 + 1/2 + 1/3 + 1/4 ..... + 1/N
        /// </summary>
        /// <param name="n"></param>
        public static double Series_6(int n)
        {
            double sum = 0;
            int loop = 1;
            while (loop <= n)
            {
                //add the next item 
                sum += (1/loop);
                //increment the loop
                loop++;
            }
            return sum;
        }

        /// <summary>
        /// series sum S = 1! + 3! + 5! + 7! + .........+N!
        /// </summary>
        /// <param name="n"></param>
        public static int Series_5(int n)
        {
            int sum = 0;
            int term = 1;
            int loop = 1;
            while (loop <= n)
            {
                //add the next item 
                sum += term;
                //update the term for next component
                term = term * (loop + 1) * (loop + 2);
                //increment the loop
                loop+=2;
            }

            return sum;
        }

        /// <summary>
        /// series sum S = 1! + 2! + 3! + 4! + .........+N!
        /// </summary>
        /// <param name="n"></param>
        public static int Series_4(int n)
        {
            int sum = 0;
            int term = 1;
            int loop = 1;
            while (loop <= n)
            {
                //add the next item 
                sum += term;
                //update the term for next component
                term = term*(loop+1);
                //increment the loop
                loop ++;
            }

            return sum;
        }


        /// <summary>
        /// series sum S = x^2 + x^4 + x^6 + ...... + x^n
        /// </summary>
        /// <param name="n"></param>
        public static int Series_3(int x, int n)
        {
            int sum = 0;
            int term = x*x;
            int loop = 1;
            while (loop <= n)
            {
                //update the term for next component
                term = term * x * x;
                //add the next item 
                sum += term;
                //increment the loop
                loop += 2;
            }

            return sum;
        }

        /// <summary>
        /// series sum S = x^1 + x^3 + x^5 + ...... + x^n
        /// </summary>
        /// <param name="n"></param>
        public static int Series_2(int x, int n)
        {
            int sum = 0;
            int term = x;
            int loop = 1;
            while (loop <= n)
            {
                //add the next item 
                sum += term;
                //update the term for next component
                term = term * x * x;
                //increment the loop
                loop+=2;
            }

            return sum;
        }


        /// <summary>
        /// series sum S = x^1 + x^2 + x^3 + ...... + x^n
        /// </summary>
        /// <param name="n"></param>
        public static int Series_1(int x , int n)
        {
            int sum = 0;
            int term = x;
            int loop = 1;
            while (loop <= n)
            {
                //add the next item 
                sum += term;
                //update the term for next component
                term = term * x;
                //increment the loop
                loop++;
            }

            return sum;
        }
    }
}
