using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
         static void Main(string[] args)
        {

            A rrr = new C();
            Console.WriteLine(rrr.Print());
            
            
            var list = from x in Enumerable.Range(2, 100)
                       from y in Enumerable.Range(2, 100)
                       let p = new { x, y, m = x * y }
                       select p;



            foreach (var item in list)
            {
                Console.WriteLine($"{item.x}  {item.y}  {item.m}  ");
            }
        }




        static bool IsPtime(int a)
        {
            for (int i = 2; i*i <= a; i++)
                if (a % i == 0) return false;
            return true;
        }
    }

    public abstract class A
    {
        public virtual string Print() { return "A"; }
    }

    public class B : A
    {
        public virtual new string Print() { return "B"; }
    }

    public class C : B
    {
        public override string Print() { return "C"; }
    }
}
