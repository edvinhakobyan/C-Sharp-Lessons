using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 10000;
            int[] q = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int i = 1;
            int count = 1;
            foreach(var w in CombinationsWithoutRepetition(q,3))
            {
                int a = w.ToArray()[0];
                int b = w.ToArray()[1];
                int c = w.ToArray()[2];

                if (a + b - 2 * c == 0 || c + b - 2 * a == 0 || a + c - 2 * b == 0)
                {
                    Console.WriteLine(i++ + "-" + a + " " + b + " " + c);

                }

                count++;
            }
            Console.WriteLine();
            Console.WriteLine(--i + "/" + --count + "=" + (double) i/ count);



        }

        static IEnumerable<IEnumerable<T>> CombinationsWithoutRepetition<T>(IEnumerable<T> list, int length) where T : IComparable

        {
            if (length == 1) return list.Select(t => new T[] { t });
            return CombinationsWithoutRepetition(list, length - 1).SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0), (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
