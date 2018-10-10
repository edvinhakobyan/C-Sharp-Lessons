using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(int arg)
        {
            if (arg == 0)
                return;

            Main(arg--);
            Loop50();
            Console.ReadKey();

        }

        static void Loop50()
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Վիքիպեդիայից՝ ազատ հանրագիտարանից");

            ulong a = ulong.MaxValue - 1;

            while (a > 1)
            {
                if (a % 2 == 0)
                    a /= 2;
                else
                    a = (3 * a + 1);

                Console.WriteLine(a);
            }
        }

        /*Խնդիր_1:
          Ներմուծել քառանիշ թիվ և հաշվել նրա թվանշանների գումարը:*/

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

        /*Խնդիր_2:
          Տրված են K և N(N > 0) ամբողջ թվերը։ N անգամ արտածել K թիվը։*/
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

        /*Խնդիր_3:
          Ներածել n միանիշ թիվը։ Արտածել n-ին չգերազանցող թվանշանները։*/
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
        /*Խնդիր_4:
          Ներածել n բնական թիվը։ Արտածել n–ի 1–ից մինչև 9 աստիճանների արժեքները։*/
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

        /*Խնդիր_5:
          Հաշվել տրված բնական թվին չգերազանցող զույգ թվերի գումարը՝ առանց զույգությունը ստուգելու։*/
        static void Loop5()
        {
            Console.WriteLine("Enter number n: n > 0 && n < int.MaxValue");
            Console.Write($"n = ");
            int n = TrueNumberFromConsole(0, int.MaxValue);
            Console.WriteLine($"(a1 + an) * n / 2 = (0 + {n}) * {n / 2} / 2 = {n * n / 4}");
            Console.ReadKey();
        }
        /*Խնդիր_7:
         Տրված են A և B (A < B) ամբողջ թվերը։ Գտնել [A, B] 
         հատվածին պատկանող բոլոր ամբողջ թվերի գումարը։*/
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

        /*Խնդիր_9:
          Տրված է N բնական թիվը։ Հաշվել 1 + 1/2 + 1/3 + … + 1/N գումարը (այն իրական թիվ է)։*/
        static void Loop9()
        {
            Console.WriteLine("Enter number N: N > 0 && N < int.MaxValue");
            Console.Write($"N = ");
            int N = TrueNumberFromConsole(0, int.MaxValue);

            double sum = 0;
            for (int i = 1; i <= N; i++)
                sum += 1.0 / i;

            Console.WriteLine($"1 + 1/2 + 1/3 + ... + 1/{N} = {sum}");
        }

        /*Խնդիր_10:
          Տրված է N բնական թիվը։ Հաշվել N^2 + (N + 1)^2 + (N + 2)^2 + … + (2·N)^2 գումարը։*/
        static void Loop10()
        {
            Console.WriteLine("Enter number N: N > 0 && N < int.MaxValue");
            Console.Write($"N = ");
            int N = TrueNumberFromConsole(0, int.MaxValue);

            ulong sum = 0;
            for (int i = 0; i <= N; i++)
                sum += (ulong)(N + i) * (ulong)(N + i);

            Console.WriteLine($"{N}^2 + ({N} + 1)^2 + ({N} + 2)^2 + . . . + (2 * {N})^2 = {sum}");
        }

        /*Տրված է N բնական թիվը։ Հաշվել 1.1 · 1.2 · 1.3 · … արտադրյալը 
        (արտադրիչների քանակը N է)։*/
        static void Loop11()
        {
            Console.WriteLine("Enter number N: A > 0 && A < int.MaxValue");
            Console.Write($"N = ");
            int N = TrueNumberFromConsole(0, int.MaxValue);

            double multy = 1;
            for (double i = 1.1; i <= (1.1 + 0.1 * N); i += 0.1)
                multy *= i;

            Console.WriteLine($"1.1 * 1.2 + 1.3 * ... (N time) = {multy}");
        }

        /*Տրված է N բնական թիվը։ Հաշվել 1.1 – 1.2 + 1.3 – … արտահայտության արժեքը։ 
          Նշանափոխ գումարելիների քանակը N է։ Պայմանական (if) օպերատոր չօգտագործել։*/
        static void Loop12()
        {
            Console.WriteLine("Enter number N: A > 0 && A < int.MaxValue");
            Console.Write($"N = ");
            int N = TrueNumberFromConsole(0, int.MaxValue);

            if ((N & 1) == 1)
                Console.WriteLine($"1.1 - 1.2 + 1.3 - ... (N time) = {-0.1 * (N-1) / 2 + (0.1 * N + 1)}");
            else
                Console.WriteLine($"1.1 - 1.2 + 1.3 - ... (N time) = {-0.1 * N / 2}");
        }

        static void Loop13()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                    Console.WriteLine($"{i} * {j} = {i * j}");
                Console.WriteLine("****************");
            }
        }

        static void Loop14()
        {
            string a = Console.ReadLine();

            int num = int.Parse(a);
            int dzaj = num;
            int l = a.Length;

            for (int i = 1; num > 0; i++)
            {
                if (!((num % 10) == dzaj / (int)(Math.Pow(10, l - i))))
                {
                    Console.WriteLine("vad a");
                    break;
                }
                num /= 10;
                dzaj %= (int)(Math.Pow(10, l - i));
            }
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
