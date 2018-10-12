using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum1
{
    class Program
    {   
        static void Main(string[] args)
        {
            double tt = Sum(10);
        }

        //                    0   1       2               3                   4
        // Console.WriteLine("1 + X/2 – 1*X^2/(2*4) + 1*3*X^3/(2*4*6) – 1*3*5*X^4/(2*4*6*8) + ... ")

        /// <summary>
        /// RETURN SUM OF THIS ROW [1 + X/2 – 1*X^2/(2*4) + 1*3*X^3/(2*4*6) – 1*3*5*X^4/(2*4*6*8) + ... ]
        /// </summary>
        /// <param name="X"></param>
        /// <returns></returns>
        static double Sum(ulong X)
        {
            ulong N = 15;
            double sum = 1;
            Console.WriteLine(sum + " +");
            for (ulong i = 1; i <= N; i++)
            {
                sum += Math.Pow(-1, i) * Numerator(i) * Math.Pow(X, i) / Denominator(i);
                Console.WriteLine("[{3}{1} * X^{0} / {2}] + ", i, Numerator(i), Denominator(i), Math.Pow(-1, i ^ 1) > 0 ? '+' : '-');
            }
            //Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop-1);
            Console.WriteLine("= " + sum);
            return sum;
        }

        /// <summary>
        /// RETURN MEBER BY INDEX OF THIS ROW [1] [1] [1] [3] [3*5] [3*5*7] [3*5*7*9]...
        /// </summary>
        /// <param name="ind">INDEX OF MEMBER</param>
        /// <returns></returns>
        static ulong Numerator(ulong ind)
        {
            if (ind < 3) return 1;
            ulong ret = 1, j = 1;
            for (ulong i = 1; i <= ind - 2; i++)
                ret *= (j += 2);
            return ret;
        }

        /// <summary>
        /// RETURN MEBER BY INDEX OF THIS ROW [1] [2] [2*4] [2*4*6] [2*4*6*8] ...
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static ulong Denominator(ulong n)
        {
            ulong ret = 1, j = 0;
            for (ulong i = 0; i < n; i++)
                ret *= (j += 2);
            return ret;
        }





    }
}
