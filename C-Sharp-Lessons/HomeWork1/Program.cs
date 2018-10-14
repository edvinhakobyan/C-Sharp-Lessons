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
            Problem21(993999999998889);
        }

        /*Խնդիր_16:
          Հաշվել տրված բնական թվի թվանշանների գումարը, քանակը, արտադրյալը։*/
        static void Problem16(ulong N)
        {
            ulong count, sum = 0, mult = 1, dig = 0;
            for (count = 0; N > 0; N /= 10, count++)
            {
                dig = N % 10; sum += dig; mult *= dig;
            }
            Console.WriteLine($" count = {count}\n sum = {sum}\n mult = {mult}");
        }


        /*Խնդիր_17:
          Գտնել տրված թվի կենտ թվանշաններից ամենափոքրը։*/
        static void Problem17(ulong N)
        {
            ulong min = 9, t = 0, n = 0;
            for (; N > 0; N /= 10)
            {
                t = N % 10;
                if ((t & 1) == 1 && t < min)
                { min = t; n++; }
            }
            Console.WriteLine(n > 0 ? $"min = {min}" : $"All Digits Are Even");
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
          Արտածել տրված թվի բոլոր բաժանարարները։*/
        static void Problem21(ulong N)  //?
        {
            for (ulong i = 1; i * i <= N; i++)
                if (N % i == 0)
                {
                    if (i * i != N)
                        Console.WriteLine("{0}\n{1}", i, N / i);
                    else
                        Console.WriteLine(i);
                }
        }

        /*Խնդիր_22:
          Հաշվել տրված թվի բոլոր բաժանարարների գումարը։*/
        static ulong Problem22(ulong N)  //?
        {
            ulong sum = 0;
            for (ulong i = 1; i * i <= N; i++)
                if (N % i == 0)
                {
                    if (i * i != N)
                        sum += (i + N / i);
                    else
                        sum += i;
                }
            Console.WriteLine(sum);
            return sum;
        }

        /*Խնդիր_24:
         Պարզել, հանդիսանում է, արդյոք, տրված թիվը 3-ի աստիճան։*/
        static void Problem24(ulong N)
        {
            ulong n = 0, N1 = N;
            for (; N > 0 && N % 3 == 0; N /= 3) n++;

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
            while((N >>= 1) > 0)  ++p;
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
