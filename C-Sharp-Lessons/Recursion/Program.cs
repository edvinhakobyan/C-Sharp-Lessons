using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Numerics;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(0, 50);
            for (int i = 0; i < 100000000; i++)
            {
                DateTime t = DateTime.Now;
                Factorial(5000*i);
                Console.SetCursorPosition(i, 50-(DateTime.Now - t).Seconds);
                Console.Write('*');
            }
            Console.ReadKey();
        }

        public static ulong recursion(ulong n, ulong i)
        {
            return (n == 0) ? i : recursion(n / 10, i * 10 + n % 10);
        }

        static BigInteger Factorial_Recursion(BigInteger n)
        {
            if (n <= 1) return 1;
            return n * Factorial_Recursion(n - 1);
        }


        static BigInteger Factorial(BigInteger n)
        {
            BigInteger ret = 1;
            for (int i = 1; i <= n; i++)
                ret = BigInteger.Multiply(ret, i);
            return ret;
        }
        

        // 1 1 2 3 5 8
        static ulong Fibonachi(ulong n)
        {
            if (n <= 1) return 1;
            return Fibonachi(n - 2) + Fibonachi(n - 1);
        }

    }
}
