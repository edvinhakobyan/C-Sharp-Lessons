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
           // for (BigInteger i = 0; i < 120; i++)
            
            Console.WriteLine(Factorial(5000));
            


        static int SumDigit(ulong n)
        {
            if (n == 0) return;


        }


        static BigInteger Factorial1(BigInteger n)
        {
            BigInteger ret = 1;
            for (int i = 1; i <= n; i++)
                ret = BigInteger.Multiply(ret, i);
            return ret;
        }

        static BigInteger Factorial(BigInteger n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }


        // 1 1 2 3 5 8
        static ulong Fibonachi(ulong n)
        {
            if (n <= 1) return 1;
            return Fibonachi(n - 2) + Fibonachi(n - 1);
        }

    }
}
