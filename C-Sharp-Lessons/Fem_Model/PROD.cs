using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fem_Model
{
    class PROD
    {
        public int PID { get; set; }
        public MAT1 mat { get; set; }
        public double A { get; set; }
        public double J { get; set; }

        public PROD(int PID, MAT1 mat, double A, double J)
        {
            this.PID = PID;
            this.mat = mat;
            this.A = A;
            this.J = J;
        }







    }
}
