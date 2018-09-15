using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Exceptions
{
    class DistanceException : Exception
    {
        public DistanceException(string message) : base (message) {}
        public DistanceException(string message, Exception innerException): base (message,innerException) {}

    }
}
