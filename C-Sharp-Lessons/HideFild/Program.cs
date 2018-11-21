using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HideFild
{

    class rr
    {
        int a, b;
        rr(int a, int b)
        {
            this.a = a*a;
            this.b = b*a;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex e = new Complex(1.2, 4.5);
            Complex c = new Complex(1.2, 4.5);
            Console.WriteLine(e + c);
        }
    }


    class Myclass
    {
        int a;
        string b;
        double c;

        public Myclass()
        {


        }

        public  Myclass(int a, string b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
        }
    }

    class Myclass1: Myclass
    {
        readonly int a;
        string b;
        double c;

        public Myclass1(int a, double c) : this(a, "", c)
        {
            this.a = a;
            this.c = c;
        }
        Myclass1(int a, string b, double c) : base(a, b, c) { }
    }


    partial class AA
    { 
}



}
