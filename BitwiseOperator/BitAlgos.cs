using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperator
{
    public  class BitAlgos
    {
        public static int CountSetBits(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
        public static bool CheckIfBitIsSet(int n  , int i)
        {
            int mask = 1 <<i;
            return (n & mask) == 1;
        }
        public static int SetTheNthBit(int n , int i)
        {
            int mask = 1 << i;
            return n | mask;
        }

        public static int ClearNthBit(int n , int i)
        {
            int mask = ~(1 << i);
            return n & mask;
        }
        
    public static int ConvertAtoB(int a,int b)
        {
            //count the number of bits need to change to convert a to b
            int res = a ^ b;
            //now find number of set bits in variable res
            //there are three methods to get the number of set bits 

            int count = 0;
            //Ist method
            //count = CountSetBits(res);


            //IInd Method
            //count = (int)Math.Log(res, 2) + 1;

            //IIIrd Method
            count = 0;
            while (res != 0)
            {
                res = res & (res - 1);
                count++;
            }


            //answer 
            return count;
        }

        public static void FindTwoDistinctElement(int[] arr)
        {
            int res = 0;
            for(int i = 0;i<arr.Length;++i)
                res^=arr[i];

            int temp = res;
            int pos = rightmostSetPos(res);
            for(int i = 0; i < arr.Length; ++i)
            {
                if (CheckIfBitIsSet(arr[i], pos))
                {
                    res^=arr[i];
                }
            }
            Console.WriteLine($"{res} & {temp ^ res}");
        }

        private static int rightmostSetPos(int n)
        {
          int count = 0 ;
            while ( n%2 == 0) {
                n >>= 1;
                count++;
            }
            return count;
        }
    }
}
