using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

        }





        static bool almostIncreasingSequence(int[] sequence)
        {

            List<int> aa = sequence.ToList();
            int Count = 0;
            for (int i = 0; i < aa.Count - 1; i++)
            {
                if (aa[i] >= aa[i + 1])
                {
                    aa.RemoveAt(i);
                    Count++;
                    if (IfIncreasing(aa))
                        return false;
                }
            }
            return true;
        }

        static bool IfIncreasing(List<int> a)
        {
            for (int i = 0; i < a.Count - 1; i++)
                if (a[i + 1] <= a[i])
                    return false;

            return true;
        }


        static bool almostIncreasingSequence1(int[] sequence)
        {
            int count = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1]) count++;
                else if (i < sequence.Length - 2 && sequence[i] >= sequence[i + 2]) count++;
            }
            return count <= 2;
        }




        public static int GetSimpleMultCount(int a)
        {
            int[] mem = new int[500];
            int count = 1, i = 2;
            while (i*i < a)
            {
                if (a % i == 0 && !mem.Contains(i))
                {
                    mem[count++] = i;
                    while (a % i == 0) a /= i;
                }
                i++;
            }
            return count;
        }

        /*Խնդիր_27:
         *Ներածել n բնական թիվը և տպել այդ թիվը՝ շրջելով և նրա ամեն մի թվանշանից հետո ավելացնելով 0 (օրինակ՝ 125 - 502010):*/
        static void Task27(ulong n)
        {
            string str = n.ToString();
            for (int i = str.Length - 1; i > -1; i--)
               Console.Write("0" + str[i]);
            Console.WriteLine();
        }

        /* Խնդիր_28:
         * Ներածել n թիվը։ Արտածել yes, եթե այն հավասար է իր թվանշանների գումարի կրկնապատիկին, no՝ հակառակ դեպքում։*/
        static string Task28(ulong n)
        {
            ulong t = n, sum = 0;
            for (; t > 0; t /= 10) sum += t % 10;
            return n == 2 * sum ? "Yes" : "No";
        }

        /*Խնդիր_29:
         * Եռանիշ թվի առաջին թվանշանը ջնջել։ Եթե ստացված թիվը բազմապատկվի 7-ով, կստացվի սկզբնական թիվը։ Գտնել այդպիսի թվերը։*/
        static void Task29()
        {
            for (int i = 100; i <= 999; i++)
            {
                int n1 = int.Parse(i.ToString().Substring(1));
                if (i == 7 * n1)
                    Console.WriteLine(i);
            }
        }

        /*Խնդիր_30:
         *Գտնել բոլոր այն քառանիշ թվերը, որոնցում կրկնվող թվանշան չկա և որոնցում առաջին և վերջին երկու թվանշաններից
         * կազմված թվերի տարբերությունը հավասար է այդ թվի թվանշանների գումարին։*/
        static void Task30()
        {
            for (int i = 1000; i < 10000; i++)
            {
                string temp = i.ToString();
                if (temp.Length == temp.Distinct().Count())
                {
                    int cur = i, sum = 0;
                    for (; cur > 0; cur /= 10) sum += cur % 10;
                    if (int.Parse(temp.Substring(0, 2)) - int.Parse(temp.Substring(2, 2)) == sum)
                        Console.WriteLine(i);
                }
            }
        }

        /*Խնդիր_31:
         * Գրել ծրագիր, որը տրված n (2 < n < 100) բնական թվի համար արտածում է բնական թվերի հաջորդականություն հետևյալ կանոններով.
         * հաջորդականության առաջին թիվը n թիվն է։
         * հաջորդականության յուրաքանչյուր հերթական թիվ ստացվում է նախորդ p թվից և հավասար է 3*p+1, եթե p-ն կենտ է,
         * և p/2, եթե p-ն զույգ է: Օրինակ, եթե n=7, պետք է արտածվի հետևյալ հաջորդականությունը. 
         * 7 22 11 34 17 52 26 13 40 20 10 5 16 8 4 2 1 Ծրագիրը պետք է ավարտի իր աշխատանքը, եթե հաջորդականության հերթական տարրը “1”-ն է։*/
        static void Task31(int n)
        {
            Console.WriteLine(n);
            while (n != 1)
                Console.WriteLine(n % 2 == 0 ? n /= 2 : n = (3 * n + 1));
        }


        /*Խնդիր_32:
         * Տրված է N բնական թիվը։ Օգտագործելով մեկ ցիկլ հաշվել 
         * 1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!) գումարը։ 
         * Ստացված թիվը հանդիսանում է e հաստատունի մոտավոր արժեքը)։*/
        static double Task32(int n)
        {
            double sum = 1, fact = 1;
            for (int i = 1; i <= n; i++, sum += 1.0 / fact)
                fact *= i;
            return sum;
        }


        /*Խնդիր_33:
         * Տրված են X իրական և N բնական թվերը։ 
         * Գտնել 1 + X + X2/(2!) + … + XN/(N!) արտահայտության արժեքը։*/
        static double Task33(double x, int n)
        {
            double sum = 1,  fact = 1;
            for (int i = 1; i <= n; i++, sum += Math.Pow(x, i - 1) / fact)
                fact *= i;
            return sum;
        }

        /*Խնդիր_34:
         * Տրված են X իրական և N բնական թվերը։ 
         * Գտնել X – X3/(3!) + X5/(5!) – … + (–1)N·X2·N+1/((2·N+1)!) արտահայտության արժեքը։
         * Ստացված թիվը sin(X)-ի մոտավոր արժեքն է։*/
        static double Task34(double x, int n)
        {
            double sum = 0, fact = 1, sign = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                if ((i & 1) == 1)
                    sum += (sign *= -1) * Math.Pow(x, i) / fact;
            }
            return sum;
        }

        /*Խնդիր_35:
         * Տրված են X իրական և N բնական թվերը։ 
         * Գտնել 1 – X2/(2!) + X4/(4!) – … + (–1)N·X2·N/((2·N)!) արտահայտության արժեքը։
         * Ստացված թիվը cos(X)-ի մոտավոր արժեքն է։*/
        static double Task35(double x, int n)
        {
            double sum = 1, fact = 1, sign = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                if ((i & 1) == 0)
                    sum += (sign *= -1) * Math.Pow(x, i) / fact;
            }
            return sum;
        }

        /*Խնդիր_36:
         * Տրված են X իրական(|X|<1) և N բնական թվերը։ 
         * Գտնել X–X2/2 + X3/3 –…+ (–1)N–1·XN/N արտահայտության արժեքը։ 
         * Ստացված թիվը ln(1+X)-ի մոտավոր արժեքն է։*/
        static double Task36(double x, int n)
        {
            double sum = 0, sign = -1;
            for (int i = 1; i <= n; i++)
                sum += (sign *= -1) * Math.Pow(x, i) / i;
            return sum;
        }

    }
}
