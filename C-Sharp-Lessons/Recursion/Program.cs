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
        static void Main(string[] args)
        {
           // for (BigInteger i = 0; i < 120; i++)
            
            Console.WriteLine(Factorial(5000));
            

            Console.ReadKey();
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
            return Fibonachi(n-2) + Fibonachi(n-1);
        }


        static void write(int num)
        {
            if(num != 0)
            {
                write(num - 1);
                Console.WriteLine($"*{num}");
                write(num - 1); 
            }
            else
                Console.WriteLine(num); 
        }
    }
}
