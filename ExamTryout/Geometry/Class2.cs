using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Geometry
    {
        private double x;
        private double y;

        public double X => x;

        public double Y => y;
        public Geometry()
        {
            x = 0;
            y = 0; 
        }
        public Geometry(double z)
        {
            x = z;
            y = z;
        }

        public Geometry(double x , double y)
        {
            x = x;
            y = y;
        }
    }

}
