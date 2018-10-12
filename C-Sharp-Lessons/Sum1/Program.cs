using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum1
{
    class Program
    {
        // Console.WriteLine("1 + X/2 – 1*X^2/(2*4) + 1*3*X^3/(2*4*6) – 1*3*5*X^4/(2*4*6*8) + ... ");
        static void Main(string[] args)
        {
            Sum(10);
        }



        static double Sum(ulong X)
        {
            ulong N = 10;
            double sum = 1;
            for (ulong i = 1; i <= N; i++)
            {
                sum += Math.Pow(-1, i) * Numerator(i) * Math.Pow(X, i) / Denominator(i);
                Console.Write("[{3}{1} * X^{0} / {2}] + ", i, Numerator(i), Denominator(i), Math.Pow(-1, i ^ 1) > 0 ? '+' : '-');
            }
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.WriteLine("= " + sum);

            return sum;
        }

        static ulong Numerator(ulong ind)
        {
            if (ind < 3) return 1;
            ulong ret = 1, j = 1;
            for (ulong i = 1; i <= ind - 2; i++)
                ret *= (j += 2);
            return ret;
        }

        static ulong Denominator(ulong n)
        {
            ulong ret = 1, j = 0;
            for (ulong i = 0; i < n; i++)
                ret *= (j += 2);
            return ret;
        }





    }
}
