using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyExample
{
    public class Example
    {
        private int factor;

        public Example(int f)
        {
            factor = f;
        }

        public int SampleMethod(int x)
        {
            Console.WriteLine("\nExample.SampleMethod({0}) executes.", x);
            return x * factor;
        }
    }
}
