using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Handling
{
    public class Basics
    {
        public void MethodForHandlingException()
        {
            try
            {
                // Main code
            }
            catch (System.ApplicationException)
            {
                // Code for handling the exception
                throw;
            }
            catch (System.Exception)
            {
                // Code for handling the exception
                throw;
            }
            finally
            {
                // Finalizing the execution of the main code
            }
        }
    }
}
