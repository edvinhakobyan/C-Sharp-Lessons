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
            Console.Write("Shape: ");
            int number = TrueNumber(1, 4);
            if (number == 1)
            {
                Console.WriteLine("Enter Length of Rectangle Sides: ");
                Console.Write("A = ");
                int A = TrueNumber(int.MinValue, int.MaxValue);
                Console.Write("B = ");
                int B = TrueNumber(int.MinValue, int.MaxValue);
                Rectangle( A, B);

            }
            else if (number == 2)
            {

            }
            else
            {

            }


        }

        private static void Rectangle(int a, int b)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    if (i == 1 || i == a)
                        Console.Write('-');
                    else
                    {
                        Console.Write('|');
                        Console.Write(new string(' ', b - 2));
                        Console.Write('|');
                        break;
                    }


                }
                Console.WriteLine();
            }
            
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
