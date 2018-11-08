using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {




            Shape[] sh = new Shape[20];





            for (int i = 0; i < sh.Length; i+=2)
            {
                Triangle t = new Triangle(i * 2.5, i * i);
                Rectangular r = new Rectangular(i * i, 10 * i);

                sh[i] = t;
                sh[i + 1] = r;
            }

            double sum = 0;

            for (int i = 0; i < sh.Length; i += 1)
            {



            }


        }



        class Shape
        {
 
            public int CornerCount { get; set; }
            public virtual double A() { return 0.0; }
        }

        class Triangle:Shape
        {
            public double B { get; set; }
            public double H { get; set; }

            public Triangle(double B, double H)
            {
                CornerCount = 3;
                this.B = B;
                this.H = H;
            }

            public override  double A()
            {
                return 0.5 * B * H;
            }
        }

        class Rectangular:Shape
        {
            public double B { get; set; }
            public double H { get; set; }

            public Rectangular(double B, double H)
            {
                CornerCount = 4;
                this.B = B;
                this.H = H;
            }

            public override  double A()
            {
                return B * H;
            }
        }




    }
}
