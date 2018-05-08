using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Handling.Examples
{
    public class Example3Wrong
    {
        public void Method1()
        {
            try
            {
                Method2();
            }
            catch (System.Exception e)
            {
                // This compiles but is wrong because we lose the 
                // original stack trace where the exception was generated
                throw e;
            }
        }

        private void Method2()
        {
            Method3();
        }

        private void Method3()
        {
            MethodN();
        }

        private void MethodN()
        {
            throw new System.Exception("My exception message");
        }
    }
}
