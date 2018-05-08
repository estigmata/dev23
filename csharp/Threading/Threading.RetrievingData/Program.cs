using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.RetrievingData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Supply the state information required by the task.
            ThreadWithState tws = new ThreadWithState(
                "This report displays the number {0}.",
                42,
                new Action<int>(ResultCallback)
            );

            Thread t = new Thread(new ThreadStart(tws.ThreadProc));
            t.Start();
            Console.WriteLine("Main thread does some work, then waits.");
            t.Join();
            Console.WriteLine("Independent task has completed; main thread ends.");
        }

        // The callback method must match the signature of the
        // callback delegate.
        public static void ResultCallback(int lineCount)
        {
            Console.WriteLine($"Independent task printed { lineCount } lines. Thread ID { Thread.CurrentThread.ManagedThreadId }");
        }
    }
}
