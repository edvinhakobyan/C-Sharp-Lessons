using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rhombus();

        }

        /// <summary>
        /// Drow Rhombus with wide and high
        /// </summary>
        static void Rhombus()
        {
            Console.BufferWidth = Int16.MaxValue - 1;

            while (true)
            {
                Console.Write("Enter the Rhombus wide: W = ");
                int w = TrueNumberFromConsole(0, Int16.MaxValue);
                Console.Write("Enter the Rhombus high: H = ");
                int h = TrueNumberFromConsole(0, Int16.MaxValue);
                Console.Write("Fill Rhombus ? 1-(if Yes) 0-(if No) ");
                int t = TrueNumberFromConsole(0, 2);

                w &= 0x1FFFFE;
                h &= 0x1FFFFE;

                double W = (double)w;
                double H = (double)h;

                for (int i = 0; i <= H; i++)
                {
                    for (int j = 0; j <= W; j++)
                    {
                        if (t == 1)
                        {
                            if (1.0 * i >= H * (W - 2 * j) / (2 * W) &&
                                1.0 * i >= j * H / W - H / 2 &&
                                1.0 * i <= 3.0 * H / 2 - j * H / W &&
                                1.0 * i <= H / 2 + j * H / W)
                                Console.Write('+');
                            else
                                Console.Write(' ');
                        }
                        else
                        {
                            if (1.0 * i == H * (W - 2 * j) / (2 * W) ||
                                1.0 * i == j * H / W - H / 2 ||
                                1.0 * i == 3.0 * H / 2 - j * H / W ||
                                1.0 * i == H / 2 + j * H / W)
                                Console.Write('+');
                            else
                                Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// Guaranteed returning the right result
        /// </summary>
        /// <param name="min">min valu</param>
        /// <param name="max">max value</param>
        /// <returns></returns>
        static int TrueNumberFromConsole(int min, int max)
        {
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number) && number >= min && number < max))
                Console.WriteLine("Wrong Selection");
            return number;
        }
    }
}