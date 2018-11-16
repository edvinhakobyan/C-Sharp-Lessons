using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideFild
{
    class Program
    {
        static void Main(string[] args)
        {

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
