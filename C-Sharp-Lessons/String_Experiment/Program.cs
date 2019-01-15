using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace String_Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5000000;

            List<string> list = new List<string>(6000000);

            Stopwatch timer = new Stopwatch();

            timer.Start();
            int i = 0;
            for (i = 0; i < 10000; i++)
                list.Add(Path.GetRandomFileName());
            Console.WriteLine($"first 10000 member add take {1.0 * timer.ElapsedMilliseconds / 10000} ms");

            for (i = 0; i < N; i++)
                list.Add(Path.GetRandomFileName());


            timer.Restart();
            for (i = 0; i < 10000; i++)
                list.Add(Path.GetRandomFileName());
            Console.WriteLine($"last 10000 member add take {1.0 * timer.ElapsedMilliseconds / 10000} ms");


            //Console.WriteLine(GC.GetTotalMemory(true));

            timer.Restart();
            list.Contains("sasasassasasasa....asa");
            Console.WriteLine($"search in list take {timer.ElapsedMilliseconds} ms");


            Console.ReadKey();

        }
    }
}
