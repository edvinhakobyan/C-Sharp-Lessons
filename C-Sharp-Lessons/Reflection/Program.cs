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
            Type t = typeof(Sort);

            FieldInfo[] Fi = t.GetFields();
            MethodInfo[] Mi = t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);


            foreach (var item in Mi)
            {
                Console.Write(item.Name);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
