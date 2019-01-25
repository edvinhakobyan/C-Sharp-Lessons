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
            
            
            foreach (var item in Fi)
            {

            }

            foreach (var item in Mi)
            {
                ParameterInfo[] Pi = item.GetParameters();

                if (item.IsPrivate)
                {
                    Console.Write("Private " + item + "(");
                    foreach (var item1 in Pi)
                    {
                        Console.Write(" " + item1.Name + " ");
                    }
                    Console.Write(")");
                    Console.WriteLine();

                }


                //    Console.WriteLine(item.Name + " " + "is Private");
                //if (item.IsPublic)
                //    Console.WriteLine(item.Name + " " + "is Public");
                //if(item.IsStatic)
                //    Console.WriteLine(item.Name + " " + "is Static");
            }





        }
    }
}
