using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    class Circle:Shape
    {
        public Point center { get; set; }
        public Line radius { get; set; }

        public Circle(Point center, Line radius)
        {
            name = "Circle";
            this.center = center;
            this.radius = radius;
        }

        public override double area()
        {
            return Math.PI * radius.length * radius.length;
        }
        public override double perimetr()
        {
            return Math.Round((2 * Math.PI * radius.length), 3);
        }

        public override string ToString()
        {
            return $"{name,-10}\nRadius: {radius.length,-10:0.000}\n" +
                   $"Perimetr: {perimetr(),-10:0.000}\nArea: {area(),-10:0.000}";
        }

    }
}
