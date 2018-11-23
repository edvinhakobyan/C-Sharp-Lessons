using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        public int F { protected get; set; }


        static void Main(string[] args)
        {
            Console.BufferHeight = 20000;
            //ttt:
            //    Console.WriteLine("Enter Circle Radius");
            //    Console.Write("R = ");
            //    double r = double.Parse(Console.ReadLine());
            //    Console.WriteLine("A = " +  Math.PI * r * r);

            //    double h = 2 * r;

            //    Random ra = new Random();

            //    double sum = 0; int N = 1000000;
            //    for (int i = 1; i <= 100; i++)
            //    {
            //        int count = 0;
            //        for (int j = 0; j <= N; j++)
            //        {
            //            Point point = new Point(h * ra.NextDouble(), h * ra.NextDouble());

            //            if ((point.x - h / 2) * (point.x - h / 2) + (point.y - h / 2) * (point.y - h / 2) <= r * r)
            //                count++;
            //        }
            //        sum += count * h * h / N;
            //    }
            //    Console.WriteLine("A = " + sum / 100.0);
            //    Console.WriteLine();
            //    goto ttt;

            Console.WriteLine("Enter Circle Radius");
            Console.Write("R = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"L = {2 * Math.PI * r}");

            List<double> t = new List<double>();

            for (int h = 500000; h <= 5000000; h+=1000)
            {
                double sum = 0;
                Point curent = new Point(r, 0);
                for (double i = 360.0 / h; i <= 360.0000001; i += (360.0 / h))
                {
                    Point p = new Point(r * Math.Cos(i * Math.PI / 180), r * Math.Sin(i * Math.PI / 180));
                    sum += Point.Length(curent, p);
                    curent = p;
                }
                Console.WriteLine(h + " " + sum);
                t.Add(sum);
            }
            ;
            Console.WriteLine(t.Average());
            Console.ReadKey();

        }

        static bool ifTrue(double a)
        {
            if (a <= 360) return true;

            if (a >= 359.99 && a <= 360.01) return true;

            return false;
        }


    }
}
