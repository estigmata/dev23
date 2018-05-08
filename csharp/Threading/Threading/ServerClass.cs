using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    public class ServerClass
    {
        // The method that will be called when the thread is started.
        public void InstanceMethod()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(
                $"ServerClass.InstanceMethod is running on another thread. [Thread ID: { Thread.CurrentThread.ManagedThreadId }]");

            // Pause for a moment to provide a delay to make
            // threads more apparent.
            Thread.Sleep(3000);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The instance method called by the worker thread has ended.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(
                $"ServerClass.StaticMethod is running on another thread. [Thread ID: { Thread.CurrentThread.ManagedThreadId }]");

            // Pause for a moment to provide a delay to make
            // threads more apparent.
            Thread.Sleep(5000);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The static method called by the worker thread has ended.");
        }
    }
}
