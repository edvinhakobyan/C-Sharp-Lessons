using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem21_22(TrueNumberFromConsole(0,ulong.MaxValue));
        }

        /*Խնդիր_16:
          Հաշվել տրված բնական թվի թվանշանների գումարը, քանակը, արտադրյալը։*/
        static void Problem16(ulong N)
        {
            ulong count = 0, sum = 0, mult = 1, dig = 0;

            for (; N > 0; N /= 10)
            {
                dig = N % 10;
                sum += dig;
                mult *= dig;
                count++;
            }
            Console.WriteLine($"count = {count}");
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"mult = {mult}");
        }


        /*Խնդիր_17:
          Գտնել տրված թվի կենտ թվանշաններից ամենափոքրը։*/
        static void Problem17(ulong N)
        {
            ulong min = 9, t = 0;
            while (N > 0)
            {
                t = N % 10;
                if ((t & 1) == 1)
                    min = t < min ? t : min;
                N /= 10;
            }
            Console.WriteLine($"min = {min}");
        }


        /*Խնդիր_18:
          Հաշվել տրված թվի 4-ից մեծ կենտ թվանշանների գումարը։*/
        static void Problem18(ulong N)
        {
            ulong sum = 0, t = 0;
            for (; N > 0; N /= 10)
            {
                t = N % 10;
                if ((t & 1) == 1 && t > 4)
                    sum += t;
            }
            Console.WriteLine($"sum = {sum}");
        }


        /*Խնդիր_19:
          Հաշվել տրված թվի 7-ից փոքր զույգ թվանշանների արտադրյալը։*/
        static void Problem19(ulong N)
        {
            ulong mult = 1, t = 0;
            for (; N > 0; N /= 10)
            {
                t = N % 10;
                if ((t & 1) == 0 && t < 7)
                    mult *= t;
            }
            Console.WriteLine($"sum = {mult}");
        }


        /*Խնդիր_20:
          Գտնել տրված թվի ամենամեծ և ամենափոքր թվանշանների տարբերության քառակուսին։*/
        static void Problem20(ulong N)
        {
            ulong max = 0, min = 9, t = 0;
            for (; N > 0; N /= 10)
            {
                t = N % 10;
                min = t < min ? t : min;
                max = t > max ? t : max;
            }
            Console.WriteLine($"(max - min)^2 = {(max - min) * (max - min)}");
        }

        /*Խնդիր_21:
          Արտածել տրված թվի բոլոր բաժանարարները։
          Խնդիր_22:
          Հաշվել տրված թվի բոլոր բաժանարարների գումարը։*/

        static void Problem21_22(ulong N)
        {
            ulong sum = N;
            for (ulong i = 1; i < N / 2; i++)
                if (N % i == 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            Console.WriteLine(N);
            Console.WriteLine("\n" + sum);
        }

        /*Խնդիր_24:
         Պարզել, հանդիսանում է, արդյոք, տրված թիվը 3-ի աստիճան։*/
        static void Problem24(ulong N)
        {
            ulong n = 0, N1 = N;
            while (N > 1 && N % 3 == 0)
            { N /= 3; n++;  }

            if (N == 1)
                Console.WriteLine($"{N1} = 3^{n}");
            else
                Console.WriteLine($"{N1} != 3^x");
        }

        /*Խնդիր_25:
          Տրված n>0 ամբողջ թվի համար հաշվել 2-ի ամենամեծ աստիճանը, որը չի գերազանցում n-ը։*/
        static void Problem25(ulong N)
        {
            ulong N1 = N, p = 0;
            while( (N >>= 1) > 0)  ++p;
            Console.WriteLine($"{N1} ~ 2^{p}");
        }

        /*Խնդիր_26:
          Գտնել տրված բնական թվից մեծ և 2-ի աստիճան հանդիսացող ամենափոքր թիվը։*/
        static void Problem26(ulong N)
        {
            ulong N1 = 1, p = 0;
            while ((N1 <<= 1) < N) ++p;
            Console.WriteLine($"{N} ~ 2^{p} = {N1}");
        }

        static ulong TrueNumberFromConsole(ulong min, ulong max)
        {
            ulong number;
            while (!(ulong.TryParse(Console.ReadLine(), out number) && number >= min && number < max))
                Console.WriteLine("Wrong Selection");
            return number;
        }
    }
}
