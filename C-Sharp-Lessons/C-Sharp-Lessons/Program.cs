using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_Sharp_Lessons
{
    class Program
    {
        static int a;
        static void Main(string[] args)
        {
            Class1 w = new Class1();

            ThreadStart deligat = new ThreadStart(w.method);
            Thread t = new Thread(deligat);
            t.Start();
        }

        public static void chenge_a()
        {
            a++;
        }
    }
}
