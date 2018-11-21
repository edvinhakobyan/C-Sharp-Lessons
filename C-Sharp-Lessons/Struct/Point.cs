using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        static public Point  AddPoint(Point a,Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }

        static public Point SubPoint(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y);
        }

        static public Point MultPoint(Point a, Point b)
        {
            return new Point(a.x * b.x, a.y * b.y);
        }

        static public Point DivtPoint(Point a, Point b)
        {
            return new Point(a.x * b.x, a.y * b.y);
        }

        static public double Length(Point a, Point b)
        {
            return Math.Sqrt((a.x - b.x)*(a.x - b.x) + (a.y - b.y) * (a.y - b.y));
        }


    }
}
