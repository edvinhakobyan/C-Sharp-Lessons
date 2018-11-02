using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fem_Model
{
    class Grid
    {
        public int Id { get; set; }
        public int CoordId { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Grid(int Id, int CoordId, double X, double Y, double Z)
        {
            this.Id = Id;
            this.CoordId = CoordId;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
}
