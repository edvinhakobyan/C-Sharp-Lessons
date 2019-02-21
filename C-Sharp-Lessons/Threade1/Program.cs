using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threade1
{
    class Program
    {
        static int x = 0;
        static object loc = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Поток " + i.ToString();
                myThread.Start();
            }

            Console.ReadLine();
        }
        public static void Count()
        {
            lock(loc)
            {
                x = 1;
                for (int i = 1; i < 20; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
