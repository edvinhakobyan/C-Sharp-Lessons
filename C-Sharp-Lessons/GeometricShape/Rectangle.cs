using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    class Rectangle: Shape
    {
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            name = "Rectangle";
            vertexs = new Point[] { a, b, c, d };
            edges = new Line[] { new Line(a, b), new Line(b, c), new Line(c, d), new Line(d, a) };
        }

        public override double area()
        {
            return edges[0].length * edges[1].length;
        }

        public override string ToString()
        {
            return $"{name,-10}\nVertex1: {vertexs[0].ToString(),-10}\nVertex2: {vertexs[1].ToString(),-10}\n" +
                   $"Vertex3: {vertexs[2].ToString()}\nVertex4: {vertexs[3].ToString()}\n" +
                   $"Perimetr: {perimetr(),-10:0.000}\nArea: {area(),-10:0.000}";
        }
    }
}
