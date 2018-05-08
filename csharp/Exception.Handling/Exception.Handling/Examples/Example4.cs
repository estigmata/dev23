using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Handling.Examples
{
    internal static class ExceptionFilter
    {
        private static void A() => B();

        private static void B() => C();

        private static void C() => D();

        private static void D()
        {
            throw new OperationCanceledException(nameof(ExceptionFilter));
        }

        private static bool Log(this object message, bool result = false)
        {
            Console.WriteLine(Environment.NewLine + "MyExtensionMethodLog.. " + message);
            return result;
        }

        /// <summary>
        /// Common catch before C# 6
        /// </summary>
        public static void Catch()
        {
            try
            {
                A();
            }
            catch (System.Exception exception)
            {
                exception.Log();
                throw;
            }
        }

        /// <summary>
        /// C# 6.0 provides a way to log or filter an exception before catching it:
        /// </summary>
        public static void When()
        {
            try
            {
                A();
            }
            catch (System.Exception exception) when (exception.Log())
            {
                // This will not be executed
                //exception.Log();
                //throw;
            }
        }

        public static void Log()
        {
            try
            {
                A();
            }
            catch (System.Exception exception) when (exception.Log(true))
            {
                //exception.Log();
                //throw;
            }
        }
    }
}
