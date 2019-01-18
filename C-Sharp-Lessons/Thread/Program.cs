using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_
{
    
    class Program
    {

        static DateTime t = DateTime.Now;

        static void secund_treade()
        {
            while (true)
                Console.WriteLine("            " + DateTime.Now.Millisecond);
        }

        static void Main(string[] args)
        {

            ThreadStart start = new ThreadStart(secund_treade);

            Thread tr = new Thread(start);

            tr.Start();

            while (true)
                Console.WriteLine(DateTime.Now.Millisecond);



        }
    }
}
