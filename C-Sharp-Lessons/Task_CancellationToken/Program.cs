using System.Threading;
using System.Threading.Tasks;

using System;
using System.Runtime;
using System.Security;
using System.Security.Permissions;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace HelloApp
{
    class Program
    {
        static void Factorial(int n, CancellationToken token)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана токеном");
                    return;
                }
                result *= i;
                Console.WriteLine($"Факториал числа {i} равен {result}");
                Thread.Sleep(1000);
            }
        }
        // определение асинхронного метода
        static async void FactorialAsync(int n, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;
            await Task.Run(() => Factorial(n, token));
        }

        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            //FactorialAsync(20, cts.Token);
            mymethod(cts.Token);
            while(true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    cts.Cancel();
                    break;
                }
            }
            Console.Read();
        }

        public static void mymethod(CancellationToken t)
        {
            if (t.IsCancellationRequested) return;

            var outer = Task.Run(() =>      // внешняя задача
            {
                for (;true;)
                {
                    Console.Write('*');
                    Thread.Sleep(100);
                }
            });

        }






    }
}