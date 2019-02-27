using System;
using System.Threading;
using System.Threading.Tasks;

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
            FactorialAsync(20, cts.Token);
            Thread.Sleep(3000);
            cts.Cancel();
            Console.Read();
        }
    }
}