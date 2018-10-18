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
            //Console.SetCursorPosition(0, 50);
            //for (ulong i = 0; i < 100000000; i++)
            //{
            //    DateTime t = DateTime.Now;
            //    Fibonachi(i);
            //    Console.SetCursorPosition((int)i, 50-(DateTime.Now - t).Seconds);
            //    Console.Write('*');
            //}
            //Console.ReadKey();
            for (ulong i = 1; i < 50; i++)
            {
                Console.WriteLine(i + " " + 1.0*Fibonachi(i)/Fibonachi(i - 1));
            }
            Console.ReadKey();

        }

        // 1 1 2 3 5 8
        static ulong Fibonachi(ulong n)
        {
            if (n <= 1) return 1;
            return Fibonachi(n - 2) + Fibonachi(n - 1);
        }



        //0 1 0 1 1 0 1 1 0 1
        public static int recursion(int a, int b)
        {
            // Базовый случай 
            if (a > b + 1)   return 0;
            
            // Базовый случай 
            if (a == 0 || b == 0) return 1;
            
            // Шаг рекурсии / рекурсивное условие
            return recursion(a, b - 1) + recursion(a - 1, b - 1);
        }

        public static String recursion1(int a, int b)
        {
            // основное условие задачи
            if (a > b)
            {
                // Базовый случай
                if (a == b)
                {
                    return a.ToString();
                }
                // Шаг рекурсии / рекурсивное условие
                return a + " " + recursion(a - 1, b);
            }
            else
            {
                // Базовый случай
                if (a == b)
                {
                    return a.ToString();
                }
                // Шаг рекурсии / рекурсивное условие
                return  recursion(a, b-1) + " " + b;
            }
        }

        public static void Convert_to_bynary1(int n, int m)
        {
            int temp = n % m;
            if (n >= 2)
                Convert_to_bynary1(n / m, m);
            Console.Write(temp);
        }

        public static String recursion(int n)
        {
            // Базовый случай
            if (n == 1)
            {
                return "1";
            }
            // Шаг рекурсии / рекурсивное условие
            return recursion(n - 1) + " " + n;
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
        



    }
}
