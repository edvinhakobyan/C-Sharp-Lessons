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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("sec thread -> " + Thread.CurrentThread.GetHashCode());
                Thread.Sleep(2000);
            }

        }

        static void Main(string[] args)
        {

            Thread[] tr = new Thread[8];

            for (int i = 0; i < 8; i++)
            {
                tr[i] = new Thread(new ThreadStart(secund_treade));
                tr[i].Start();
                //tr[i].IsBackground = true;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("main thread -> " + Thread.CurrentThread.GetHashCode());
                Thread.Sleep(500);
            }

            Console.WriteLine("--------------");

            //for (int i = 0; i < 8; i++) tr[i].Join();

            //Console.ReadKey();
        }
    }
}
