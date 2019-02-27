using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Return
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = FactorialAsyncVoid_(10);
        }

        static async void Met()
        {
            int a = await FactorialAsyncInt(20); 
        }

        //void
        static async void FactorialAsyncVoid(int n)
        {
            await Task.Run(() => FactorialVoid(n));
        }

        //Task
        static async Task FactorialAsyncVoid_(int n)
        {
            await Task.Run(() => FactorialInt(n));
        }

        //Task<int>
        static async Task<int> FactorialAsyncInt(int n)
        {
            return await Task.Run(() => FactorialInt(n));
        }

        //ValueTask<int> 
        static async ValueTask<int> FactorialAsync(int n)
        {
            return await Task.Run(() => FactorialInt(n));
        }






        static void FactorialVoid(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал равен {result}");
        }

        static int FactorialInt(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }


    }
}
