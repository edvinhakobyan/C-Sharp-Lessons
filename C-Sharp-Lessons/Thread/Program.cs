using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter co = new Counter(10, 20);
            Thread tr = new Thread(new ThreadStart(co.Count));
            tr.Start();

            ParameterizedThreadStart();
            treade_examle1();
            abautTreade();
        }


        static void abautTreade()
        {
            // получаем текущий поток
            Thread t = Thread.CurrentThread;

            //получаем имя потока
            Console.WriteLine("Имя потока: {0}", t.Name);
            t.Name = "Метод Main";
            Console.WriteLine("Имя потока: {0}", t.Name);

            Console.WriteLine("Запущен ли поток: {0}", t.IsAlive);
            Console.WriteLine("Приоритет потока: {0}", t.Priority);
            Console.WriteLine("Статус потока: {0}", t.ThreadState);

            // получаем домен приложения
            Console.WriteLine("Домен приложения: {0}", Thread.GetDomain().FriendlyName);
            Console.ReadLine();
        }

        static void treade_examle1()
        {
            // создаем новый поток
            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start(); // запускаем поток

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
            Console.ReadLine();
        }

        public static void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }

        static void ParameterizedThreadStart()
        {
            int[] number = new int[] { 1, 2, 3, 4, 5, 6 };
            // создаем новый поток
            Thread myThread = new Thread(new ParameterizedThreadStart(Count));
            myThread.Start(number);

            for (int i = 1; i < 9; i++)
            {
                Console.Write("Главный поток: -> ");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
            Console.ReadLine();
        }

        public static void Count(object x)
        {
            x = x as int[];

            for (int i = 1; i < 9; i++)
            {
                Console.Write("Второй поток: -> ");
                Console.WriteLine(x);
                Thread.Sleep(400);
            }
        }
    }

    public class Counter
    {
        private int x;
        private int y;

        public Counter(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * x * y);
                Thread.Sleep(400);
            }
        }
    }


}
