using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Handling.Examples
{
    public class Example1
    {
        public void Method1()
        {
            Method2();
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
            throw new System.Exception("Exception from MethodN");
        }
    }
}
