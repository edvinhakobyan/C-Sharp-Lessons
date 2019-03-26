using System;
using System.Reflection;

namespace Atributs
{
    [My(a = 10, b = "eee")]
    class Program
    {
        static void Main(string[] args)
        {
            myclass mc = new myclass();
            Type t = typeof(myclass);
            object[] atribs = t.GetCustomAttributes(true);

            //foreach (var item in atribs)
            //{
            //    MyAttribute ty = item as MyAttribute; 
            //    Console.WriteLine(ty.a + " " +  ty.b);
            //}

            Assembly asem = Assembly.GetExecutingAssembly();
            atribs = asem.GetCustomAttributes(false);

            foreach (var item in atribs)
            {
                Console.WriteLine(item.GetType().Name);
            }



            Console.WriteLine("Hello World!");
        }
    }

    [My(a = 56, b = "ewdvin")]
    class myclass : Program
    {


    }
}
