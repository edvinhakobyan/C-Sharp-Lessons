using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Recursion
{
    class Program
    {
        static void Main1(string[] args)
        {
           for (ulong i = 0; i < 10; i++)
            Console.WriteLine(Fibonachi(i));
            

            Console.ReadKey();
        }


        static int SumDigit(ulong n)
        {
            if (n == 0) return;


        }


        static BigInteger Factorial(BigInteger n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }


        // 1 1 2 3 5 8
        static ulong Fibonachi(ulong n)
        {
            if (n < 2) return n;
            return Fibonachi(n-2) + Fibonachi(n-1);
        }


    }
}
