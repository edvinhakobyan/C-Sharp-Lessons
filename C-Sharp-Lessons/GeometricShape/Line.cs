using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    class Line:Shape
    {
        public double length { get; set; }

        public Line(Point a, Point b)
        {
            name = "Line";
            vertexs = new Point[] { a, b};
            length = Math.Pow(Math.Pow((a.x - b.x), 2.0) + Math.Pow((a.y - b.y), 2.0), 0.5);
        }
    }
}
