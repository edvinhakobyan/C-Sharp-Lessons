using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop1();
            Loop2();
            Loop3();
            Loop4();
            Loop5();
            Loop7();

        }

        static void Loop1()
        {
            Console.WriteLine("Enter number N >= 1000 && N < 10000");
            Console.Write($"N = ");
            int a = TrueNumberFromConsole(1000, 10000);
            int sum = 0;
            for (; a > 0;)
            {
                Console.Write(a % 10 + " + ");
                sum += a % 10;
                a /= 10;
            }
            Console.CursorLeft = Console.CursorLeft - 2;
            Console.WriteLine($"= {sum}");
            Console.ReadKey();
        }


        static void Loop2()
        {
            Console.WriteLine("Enter number N: N > 0 && N < int.MaxValue");
            Console.Write($"N = ");
            int N = TrueNumberFromConsole(0, int.MaxValue);
            Console.WriteLine("Enter number K:");
            Console.Write($"K = ");
            int K = TrueNumberFromConsole(int.MinValue, int.MaxValue);

            for (int i = 0; i < N; i++)
                Console.WriteLine(K);
            Console.ReadKey();
        }

        static void Loop3()
        {
            Console.WriteLine("Enter number n: n > 0 && n < 10");
            Console.Write($"n = ");
            int n = TrueNumberFromConsole(0, 10);

            for (int i = 0; i <= n; i++)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Loop4()
        {
            Console.WriteLine("Enter number n: n > 0 && n < MaxValue");
            Console.Write($"n = ");
            int n = TrueNumberFromConsole(0, int.MaxValue);

            for (int i = 1; i <= 9; i++)
            {
                ulong step = (ulong)n;
                for (int j = 1; j < i; j++)
                    step *= (ulong)n;      //checked {step *= (ulong)n; }
                Console.WriteLine($"n ^ {i} = {step}");
            }
            Console.ReadKey();
        }

        static void Loop5()
        {
            Console.WriteLine("Enter number n: n > 0 && n < int.MaxValue");
            Console.Write($"n = ");
            int n = TrueNumberFromConsole(0, int.MaxValue);
            Console.WriteLine($"(a1 + an) * n / 2 = (0 + {n}) * {n / 2} / 2 = {n * n / 4}");
            Console.ReadKey();
        }

        static void Loop7()
        {
            Console.WriteLine("Enter number A: A > int.MinValue && A < MaxValue");
            Console.Write($"A = ");
            int A = TrueNumberFromConsole(int.MinValue, int.MaxValue);
            Console.WriteLine("Enter number B: B > A && B < MaxValue");
            Console.Write($"B = ");
            int B = TrueNumberFromConsole(A, int.MaxValue);
            Console.WriteLine($"(a1 + an) * n / 2 = ({A} + {B}) * {B - A + 1} / 2  = {(A + B) * (B - A + 1) / 2}");
            Console.ReadKey();
        }


        static int TrueNumberFromConsole(int min, int max)
        {
            int number;
            for(; !(int.TryParse(Console.ReadLine(), out number) && number >= min && number < max); )
                Console.WriteLine("Wrong Selection");
            return number;
        }
    }
}
