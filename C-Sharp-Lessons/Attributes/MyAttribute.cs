using System;
using System.Collections.Generic;
using System.Text;

namespace Atributs
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple = true, Inherited = true)]
    class MyAttribute : Attribute
    {
        public int a;
        public string b;
    }
}
