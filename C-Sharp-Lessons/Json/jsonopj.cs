using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class jsonopj
    {

        public class Rootobject
        {
            public int[] array { get; set; }
            public bool boolean { get; set; }
            public string color { get; set; }
            public object _null { get; set; }
            public int number { get; set; }
            public Object _object { get; set; }
            public string _string { get; set; }
        }

        public class Object
        {
            public string a { get; set; }
            public string c { get; set; }
            public string e { get; set; }
        }

    }
}
