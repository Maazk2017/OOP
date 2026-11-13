using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    internal class InvalidEmployeeIDException : Exception
    {
        public InvalidEmployeeIDException(string message) :base(message)
        {

        }
    }
}
