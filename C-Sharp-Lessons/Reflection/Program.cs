using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingGeneric;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 220;
            Assembly a = Assembly.Load("SortingGeneric");
            Type[] tps = a.GetTypes();

            foreach (var item1 in tps)
            {
                Console.WriteLine(item1);
                Console.WriteLine();
                Type t = item1.GetType();
                FieldInfo[] Fi = t.GetFields();
                MethodInfo[] Mi = t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

                foreach (var item2 in Mi)
                {
                    Console.Write(item2);
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}
