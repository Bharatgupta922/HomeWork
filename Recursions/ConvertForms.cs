using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    public static class ConvertForms
    {
        public static string DecimalToBin(int n)
        {
            if (n > 0)
            {
                return n%2 +  DecimalToBin(n / 2) ;
            }
            return "";
        }
    }
}
