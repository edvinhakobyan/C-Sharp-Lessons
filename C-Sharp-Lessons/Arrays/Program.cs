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

            Console.ReadKey();
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
                if (temp.Length == temp.Distinct().Count() )
                {
                    int cur = i, sum = 0;
                    for (; cur > 0; cur /= 10, sum += cur % 10)
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
            {
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = (3 * n + 1);
                Console.WriteLine(n);
            }
        }




    }
}
