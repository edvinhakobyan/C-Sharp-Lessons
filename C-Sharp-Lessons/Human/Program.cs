using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            Human h1 = new Human("Edvin");
            Human h2 = new Human("Edvin", "Hakobyan");
            Human h3 = new Human("Edvin", "Hakobyan", 33);
            Human h4 = new Human("Edvin", "Hakobyan", 33, 77);
            Human h5 = new Human("Edvin", "Hakobyan", 33, 77, "Man");

        }
    }
}
