using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Kulazhin
{
    class TwoDimensionPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public TwoDimensionPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public TwoDimensionPoint()
        {
            X = 0;
            Y = 0;
        }
    }
}
