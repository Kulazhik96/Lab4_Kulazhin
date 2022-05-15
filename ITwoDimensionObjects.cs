using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Kulazhin
{
    interface ITwoDimensionObjects
    {
        public void Move(double x, double y);
        public void Resize(double length, double width);
    }
}
