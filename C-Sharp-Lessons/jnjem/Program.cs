using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace jnjem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(1000000);
            Stopwatch timer = new Stopwatch();

            for (int i = 0; i < list.Capacity; i++)
            {

                if(i==100 || i == list.Capacity - 100)
                {
                    timer.Start();
                    list.Add(Path.GetRandomFileName());
                    timer.Stop();
                    Console.WriteLine(timer.ElapsedMilliseconds);
                }
                else 
                {
                    list.Add(Path.GetRandomFileName());
                }
            }
            Console.ReadKey();

        }
    }
}
