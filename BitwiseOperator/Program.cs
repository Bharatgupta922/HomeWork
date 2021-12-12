
using System;
namespace BitwiseOperator
{
    class Program
    {
        public static bool   isPrime(int n)
        {
            if (n == 0 || n == 1) return false;
            for(int i = 2;  i*i <= n; ++i)
                if (n % i == 0) return false;
            return true;
        }
        static void Main(string[] args)
        {

            int a = 4, b = 6;

            Console.WriteLine($"a & b --> {a & b}");
            Console.WriteLine($"a | b --> {a | b}");
            Console.WriteLine($"~a --> {~a}");
            Console.WriteLine($"a ^ b --> {a ^ b}");
            
            //for +ve numbers padding always of 0 , for -ve numbers padding always compiler dependent
            Console.WriteLine($"a << 1 --> {a << 1}");
            //in big number cases left shift will give -ve number for occupying the mpst significant bit 
            Console.WriteLine($"b >> 1 --> {b >> 1}");
            
            Console.WriteLine($"Count set bits in {a} --> {BitAlgos.CountSetBits(a)}");
            Console.WriteLine($"Check if the 3 bit of 4 is set or not {BitAlgos.CheckIfBitIsSet(4,2)}");
            Console.WriteLine($"set the 1st bit of 4 {BitAlgos.SetTheNthBit(4,1)}");
            Console.WriteLine($"number of bits need to change to convert {22} to {27} is {BitAlgos.ConvertAtoB(22,27)}; ");

            int[] arr = { 5, 4, 1, 4, 3, 5, 1 };
            int res = 0;
            for(int i =0; i <arr.Length; ++i)
                res ^= arr[i];
            Console.WriteLine($"The only non repeatnig number in array arr --> {res}");
            Console.WriteLine("------------------------------------------------------");
            int[] brr = { 5, 4, 1, 4, 3, 5 , 1, 2 };
            BitAlgos.FindTwoDistinctElement(brr);
        
        }

    }
}