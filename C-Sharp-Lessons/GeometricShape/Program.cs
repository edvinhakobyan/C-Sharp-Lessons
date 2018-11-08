using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Shape[] shp = new Shape[20];

            for (int i = 0; i < shp.Length; i++)
                shp[i] = GetRandomShape();

            for (int i = 0; i < shp.Length; i++)
            {
               Console.WriteLine(shp[i].ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static Shape GetRandomShape()
        {
            int t = rand.Next(30000);

            if (t < 10000)
            {
                return new Triangle(RandomPoint(), RandomPoint(), RandomPoint());
            }
            else if (t < 20000)
            {
                return new Rectangle(RandomPoint(), RandomPoint(), RandomPoint(),RandomPoint());
            }
            else
            {
                return new Circle(RandomPoint(), new Line(RandomPoint(), RandomPoint()));
            }
        }

        public static Point RandomPoint()
        {
            return new Point(100 * rand.NextDouble(), 100 * rand.NextDouble());
        }
    }
}
