using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Taska_Serial_and_Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialSerial();
            Console.Read();
        }

        static void Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {result}");
            Thread.Sleep(10000);
        }

        // определение асинхронного метода
        static async void FactorialSerial()
        {
            await Task.Run(() => Factorial(4));
            await Task.Run(() => Factorial(3));
            await Task.Run(() => Factorial(5));
            await Task.Run(() => Factorial(4));
            await Task.Run(() => Factorial(3));
            await Task.Run(() => Factorial(5));
            await Task.Run(() => Factorial(4));
            await Task.Run(() => Factorial(3));
            await Task.Run(() => Factorial(5));
        }
        //Serial and parallel
        static async void FactorialParallel()
        {

            Task t1 = Task.Run(() => Factorial(4));
            Task t2 = Task.Run(() => Factorial(3));
            Task t3 = Task.Run(() => Factorial(5));
            Task t4 = Task.Run(() => Factorial(4));
            Task t5 = Task.Run(() => Factorial(3));
            Task t6 = Task.Run(() => Factorial(5));
            Task t7 = Task.Run(() => Factorial(4));
            Task t8 = Task.Run(() => Factorial(3));
            Task t9 = Task.Run(() => Factorial(5));

            await Task.WhenAll(new[] { t1, t2, t3, t4, t5, t6, t7, t8, t9 });
        }
    }
}
