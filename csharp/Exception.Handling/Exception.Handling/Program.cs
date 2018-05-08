using Exception.Handling.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //var example1 = new Example1();
            //example1.Method1();

            //var example2 = new Example2();
            //example2.Method1();

            //var example3 = new Example3Wrong();
            //example3.Method1();

            //ExceptionFilter.Catch();
            //ExceptionFilter.When();
            ExceptionFilter.Log();

            Console.ReadKey();
        }
    }
}
