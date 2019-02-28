using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Semaphore
{
    public static class ooo
    {
        public static bool isEven(this int a)
        {
            return a % 2 == 0 ? true : false;
        }
    }

    public class A
    {
        public string a = "";
        public A(string a)
        {
            this.a = a;
        }

        public virtual void show()
        {
            Console.WriteLine("My name is Edvin");
        }
    }

    class B : A
    {
        public B(string a) : base(a) { }
        public override void show()
        {
            Console.WriteLine("rtrtrt");
        }
    }

     class C: B
    {
        public C(string a) : base(a) { }
        public new void show()
        {
            Console.WriteLine("rtrtrt");
        }
    }

    class Program 
    {
        static object a = new object();
        static Random random = new Random();

        static void Main(string[] args)
        {
            C x = new C("");

            ((A)x).show();


            Console.BufferHeight = 2200;
            for (int i = 0; i < 50; i++)
            {
                ParameterizedThreadStart PTS = new ParameterizedThreadStart(Method);
                Thread tr = new Thread(PTS);
                tr.Name = i.ToString();
                tr.Start(new int[] {i, 0 , random.Next(100,1000)});
                Thread.Sleep(100);
            }
        }

        public static void Method(object ob)
        {
            int[] param = ob as int[];
            while (true)
            {
                lock (a)
                {
                    Console.CursorTop = param[0];
                    Console.CursorLeft = param[1]++;
                    Console.Write("->" + Thread.CurrentThread.Name);
                    if (param[1] == 70)
                    {
                        param[1] = 0;
                        Console.CursorLeft = 0;
                        Console.Write(new string(' ', 75));
                        Console.CursorLeft = 0;
                    }
                }
                Thread.Sleep(param[2]);
            }
        }
    }
}
