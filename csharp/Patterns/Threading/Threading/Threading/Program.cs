using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main thread: { Thread.CurrentThread.ManagedThreadId }");

            ServerClass serverObject = new ServerClass();

            // Create the thread object, passing in the
            // serverObject.InstanceMethod method using a
            // ThreadStart delegate.
            Thread InstanceCaller = new Thread(new ThreadStart(serverObject.InstanceMethod));

            // Start the thread.
            InstanceCaller.Start();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The Main() thread calls this after "
                + "starting the new InstanceCaller thread.");

            // Create the thread object, passing in the
            // serverObject.StaticMethod method using a
            // ThreadStart delegate.
            Thread StaticCaller = new Thread(new ThreadStart(ServerClass.StaticMethod));

            // Start the thread.
            StaticCaller.Start();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The Main() thread calls this after "
                + "starting the new StaticCaller thread.");
        }
    }
}
