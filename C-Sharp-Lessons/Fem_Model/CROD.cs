using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fem_Model
{
    class CROD
    {
        public int EID { get; set; }
        public PROD prop { get; set; }
        public Grid Grid1 { get; set; }
        public Grid Grid2 { get; set; }

        public CROD(int EID, PROD prop, Grid Grid1, Grid Grid2)
        {
            this.EID = EID;
            this.prop = prop;
            this.Grid1 = Grid1;
            this.Grid2 = Grid2;
        }
    }
}
