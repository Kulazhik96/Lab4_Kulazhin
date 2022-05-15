using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Kulazhin.Lab4Exceptions
{
    class NotIntersectException : Exception
    {
        public NotIntersectException(string message) : base(message) { }
    }
}
