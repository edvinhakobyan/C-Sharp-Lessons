using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fem_Model
{
    class Program
    {
        static void Main()
        {

            Grid A = new Grid(1, 0, 0, 0, 0);
            Grid B = new Grid(2, 0, 10, 0, 0);
            Grid C = new Grid(3, 0, 20, 0, 0);

            MAT1 Alum = new MAT1(7200, 0.3, 2700e-9);

            PROD prop = new PROD(1, Alum, 25.3, 23.5);

            CROD Elm1 = new CROD(1, prop, A, B);
            CROD Elm2 = new CROD(2, prop, B, C);

        }
    }
}
