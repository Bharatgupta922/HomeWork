using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public  class Series
    {
            public static int  Sum_of_n_natural(int n)
        {
            
            int sum = 0;
            int term = 1;
            int loop = 1;
            while (loop <= n)
            {
                sum += term;
                term++;
                loop++;
            }
            return sum;
        }
        /// <summary>
        ///  series of sum of n odd natural numbers S = 1 + 3 + 5 + 7 .... upto n terms 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Sum_of_n_Odd_natural(int n)
        {
            int sum = 0;
            int term = 1;
            int loop = 1;
            while (loop <= n)
            {
                // add the sum 
                sum += term;
                //update the term or get the next term 
                term+=2;
                //update the loop 
                loop++;
            }
            return sum;
        }
    }
}
