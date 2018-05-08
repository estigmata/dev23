using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.RetrievingData
{
    // The ThreadWithState class contains the information needed for
    // a task, the method that executes the task, and a delegate
    // to call when the task is complete.
    public class ThreadWithState
    {
        // State information used in the task.
        private string boilerplate;
        private int value;

        // Delegate used to execute the callback method when the
        // task is complete.
        private Action<int> callback;

        // The constructor obtains the state information and the
        // callback delegate.
        public ThreadWithState(string text, int number, Action<int> callbackDelegate)
        {
            boilerplate = text;
            value = number;
            callback = callbackDelegate;
        }

        // The thread procedure performs the task, such as
        // formatting and printing a document, and then invokes
        // the callback delegate with the number of lines printed.
        public void ThreadProc()
        {
            Console.WriteLine(boilerplate, value);
            Console.WriteLine($"Inside   Thread ID { Thread.CurrentThread.ManagedThreadId }");

            callback?.Invoke(1);
        }
    }
}
