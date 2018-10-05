using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select shape:");
            Console.WriteLine("1: Rectangle");
            Console.WriteLine("2: Circle");
            Console.WriteLine("3: Rhombus");
            while (true)
            {
                Console.Write("Shape: ");
                int number = TrueNumber(1, 4);
                if (number == 1)
                {
                    Console.WriteLine("Enter Length of Rectangle Sides: ");
                    Console.Write("A = ");
                    int A = TrueNumber(0, int.MaxValue);
                    Console.Write("B = ");
                    int B = TrueNumber(0, int.MaxValue);
                    Rectangle(A, B);
                }
                else if (number == 2)
                {
                    Console.WriteLine("Enter Radius of Circle: ");
                    Console.Write("R = ");
                    int R = TrueNumber(0, int.MaxValue);
                    Circle(R);
                }
                else
                {

                }
            }
        }

        private static void Circle(int r)
        {
            Console.WriteLine();
            int a = Console.WindowWidth / 3;
            int b = Console.CursorTop + r + 5;


            for (int i = 0; i < 2 * r + 1; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 20 * r; j++)
                {
                    if (j == a)
                    {

                    }
                    int temp = ((a - j) * (a - j) + (b - i) * (b - i));
                    if (temp == (r * r))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
            }

        }

        private static void Rectangle(int w, int h)
        {
            Console.WriteLine();
            int A = w * h;
            int min = w <= h ? w : h;
            int max = min == w ? h : w;

            w = max;
            h = min;

            int wScale = Console.WindowWidth / 3;
            int hScale = wScale * min / max;

            hScale = hScale > 2 ? hScale : 3;
            hScale |= 1;

            int x = Console.CursorLeft + 10;
            int y = Console.CursorTop;

            int wLength = max.ToString().Length;
            int hLength = min.ToString().Length;
            int ALength = $"A = {A}".Length;

            for (int i = 1; i <= hScale; i++)
            {
                Console.Write(new string(' ', 10));
                for (int j = 1; j <= wScale; j++)
                {
                    if (i == 1 || i == hScale)
                    {
                        if (j == 1 || j == wScale)
                            Console.Write('+');
                        else
                            Console.Write('-');
                    }
                    else
                    {
                        if (j == 1 || j == wScale)
                            Console.Write('|');
                        else
                            Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(x + wScale / 2 - wLength + 1, y - 1);
            Console.Write(max);
            Console.SetCursorPosition(x - hLength, y + hScale / 2);
            Console.Write(min);
            Console.SetCursorPosition(x + (wScale - ALength) / 2, y + hScale / 2);
            Console.Write($"A = {A}");
            Console.SetCursorPosition(0, y + hScale);
            Console.WriteLine();
        }

        static int TrueNumber(int min, int max)
        {
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number) && number >= min && number < max))
                Console.WriteLine("Wrong Selection");
            return number;
        }
    }
}
