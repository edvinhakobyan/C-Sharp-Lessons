using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Treade_Semaphore
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i < 20; i++)
            {
                Thread th = new Thread(new ThreadStart(dosomething_Semaphore));
                th.Name = $"Number {i}";
                th.Start();
            }

            Console.ReadLine();
        }

        static object @lock = new object();
        static Semaphore sem = new Semaphore(1, 1);
        static Mutex mut = new Mutex();
        static void dosomething_lock()
        {
            lock (@lock)
            {
                Console.WriteLine($"Start {Thread.CurrentThread.Name}");
                Thread.Sleep(1000);
                Console.WriteLine($"End {Thread.CurrentThread.Name}");
            }
        }

        static void dosomething_Semaphore()
        {
            sem.WaitOne();

            Console.WriteLine($"Start {Thread.CurrentThread.Name}");
            Thread.Sleep(5000);
            Console.WriteLine($"End {Thread.CurrentThread.Name}");

            sem.Release();
        }

    }




    class Reader
    {
        // создаем семафор
        static Semaphore sem = new Semaphore(3, 3);
        Thread myThread;
        int count = 3;// счетчик чтения

        public Reader(int i)
        {
            myThread = new Thread(new ThreadStart(Read));
            myThread.Name = $"Читатель {i}";
            myThread.Start();
        }

        public void Read()
        {
            while (count > 0)
            {
                sem.WaitOne();

                Console.WriteLine("{0} входит в библиотеку", Thread.CurrentThread.Name);

                Console.WriteLine("{0} читает", Thread.CurrentThread.Name);
                Thread.Sleep(5000);

                Console.WriteLine("{0} покидает библиотеку", Thread.CurrentThread.Name);

                sem.Release();

                count--;
            }
        }
    }
}
