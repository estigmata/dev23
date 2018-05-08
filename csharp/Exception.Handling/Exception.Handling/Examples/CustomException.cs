using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Handling.Examples
{
    /// <summary>
    /// The name of the class should end with the work "Exception".
    /// The class should have the 3 common constructors for any type of exception.
    /// </summary>
    public class CustomException : ApplicationException
    {
        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}
