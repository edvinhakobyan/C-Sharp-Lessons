using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fem_Model
{
    class MAT1
    {
        public int MID { get; set; }
        public double E { get; set; }
        public double mu { get; set; }
        public double den { get; set; }

        public MAT1(double E, double mu, double den)
        {
            this.E = E;
            this.mu = mu;
            this.den = den;
        }


    }
}
