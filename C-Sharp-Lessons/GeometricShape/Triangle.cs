using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    class Triangle: Shape
    {
        public Triangle(Point a, Point b, Point c)
        {
            name = "Triangle";
            vertexs = new Point[] { a, b, c };
            edges = new Line[] { new Line(a, b), new Line(b, c), new Line(c, a) };
        }

        public override double area()
        {
            double a = (vertexs[2].y - vertexs[1].y) * vertexs[0].x -
                       (vertexs[2].x - vertexs[1].x) * vertexs[0].y +
                        vertexs[2].x * vertexs[1].y - vertexs[2].y * vertexs[1].x;
            double b = Math.Pow(Math.Pow((vertexs[2].y - vertexs[1].y), 2.0) + 
                                Math.Pow((vertexs[2].x - vertexs[1].x), 2.0), 0.5);
            double H = a / b;

            return edges[1].length * H; 
        }

        public override string ToString()
        {
            return $"{name,-10:0.000}\nVertex1: {vertexs[0].ToString()}\n" +
                   $"Vertex2: {vertexs[1].ToString()}\nVertex3: {vertexs[2].ToString()}\n" +
                   $"Perimetr: {perimetr(),-10:0.000}\nArea: {area(),-10:0.000}";
        }
    }
}
