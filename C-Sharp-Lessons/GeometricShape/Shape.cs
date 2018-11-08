using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    class Shape
    {
        public string name { get; set; }
        public  Point[] vertexs { get; set; }
        public Line[] edges { get; set; }

        public Shape()
        {
            
        }

        public virtual double perimetr()  //ba vor shape sarqen esh esh
        {
            double sum = 0;
            for (int i = 0; i < edges.Length; i++)
                sum += edges[i].length;
            return Math.Round(sum,3);
        }

        public virtual double area() { return 0.0; }
    }
}
