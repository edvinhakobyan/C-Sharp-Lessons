using System;
using System.Diagnostics;
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

            foreach (var item in atribs)
            {
                MyAttribute ty = item as MyAttribute;
                Console.WriteLine(ty.a + " " + ty.b);
            }

            Assembly asem = Assembly.GetExecutingAssembly();
            atribs = asem.GetCustomAttributes(false);

            foreach (var item in atribs)
            {
                Console.WriteLine(item.GetType().Name);
            }

            myclass.mybool();

            myclass.mybool(10);

            Console.WriteLine("Hello World!");
        }
    }



    [My(a = 56, b = "edvin")]
    class myclass : Program
    {
        [Obsolete("Old, very old Functia")]
        public static bool mybool()
        {
            return true;
        }

        [Conditional("Dvo")]
        public static void mybool(int a)
        {
            return;
        }

#if DEBUG
        [Conditional("Dvo")]
        public static void mybool(int a, int b)
        {
            return;
        }
#else
        [Conditional("Dvo")]
        public static void mybool(int a, string b)
        {
            return;
        }
#endif

    }
}
