using System;
using System.Threading;

namespace AsynchronousProgramming
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            var myDelegate = new Action(Method);
            

            // Выполнение метода Method в отдельном потоке, взятом из пула потоков.
            myDelegate.BeginInvoke(null, null);
            Console.WriteLine("Main");
            // Delay.
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(50);
                Console.Write(".");
            }
            Console.ReadKey();
        }

        // Метод для выполнения в отдельном потоке.
        static void Method()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nАсинхронный метод запущен.");
            Console.WriteLine("\nВторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(60);
                Console.Write("A");
            }

            Console.WriteLine("Асинхронная операция завершена.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
