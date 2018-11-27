using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point() { }
        public Point (double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void transform(double x, double y)
        {
            this.x += x;
            this.y += y;
        }



        public override string ToString()
        {
            return $"(x: {x:0.000} y: {y:0.000})";
        }




    }
}
