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
                return DecimalToBin(n / 2) + n % 2;
            }
            return "";
        }

        public static string GenralConversionWithBase(int n , int b)
        {
            if (n > 0)
            {
                return GenralConversionWithBase(n / b,b);
            }
            return "";
        }
    }
}