using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_returnResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task0 = new Task<int>(() => Multy(5, 250));
            task0.Start();

            Console.WriteLine($"{task0.Result}");

            Task<int> task1 = new Task<int>(() => Factorial(5));
            task1.Start();

            Console.WriteLine($"Факториал числа 5 равен {task1.Result}");

            Task<Book> task2 = new Task<Book>(() =>
            {
                return new Book { Title = "Война и мир", Author = "Л. Толстой" };
            });
            task2.Start();

            Book b = task2.Result;
            Console.WriteLine($"Название книги: {b.Title}, автор: {b.Author}");

            Console.ReadLine();
        }

        static int Factorial(int x)
        {
            if (x == 1) return x;
            return x * Factorial(x-1);
        }

        static int Multy(int x, int y)
        {
            return x * y;
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
