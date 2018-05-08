using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListThreading
{
    class Program
    {
        static public Object lockObject = new Object();

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> Container = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }

            MyThread listing1 = new MyThread(list, ref Container, PrintList);
            MyThread listing2 = new MyThread(list, ref Container, PrintList);
            MyThread listing3 = new MyThread(list, ref Container, PrintList);
            MyThread listing4 = new MyThread(list, ref Container, PrintList);
            MyThread listing5 = new MyThread(list, ref Container, PrintList);
            MyThread listing6 = new MyThread(list, ref Container, PrintList);
            MyThread listing7 = new MyThread(list, ref Container, PrintList);
            MyThread listing8 = new MyThread(list, ref Container, PrintList);
            MyThread listing9 = new MyThread(list, ref Container, PrintList);

            Thread t1 = new Thread(new ThreadStart(listing1.Compare));
            Thread t2 = new Thread(new ThreadStart(listing2.Compare));
            Thread t3 = new Thread(new ThreadStart(listing3.Compare));
            Thread t4 = new Thread(new ThreadStart(listing4.Compare));
            Thread t5 = new Thread(new ThreadStart(listing5.Compare));
            Thread t6 = new Thread(new ThreadStart(listing6.Compare));
            Thread t7 = new Thread(new ThreadStart(listing7.Compare));
            Thread t8 = new Thread(new ThreadStart(listing8.Compare));
            Thread t9 = new Thread(new ThreadStart(listing9.Compare));
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            t6.Join();
            t7.Join();
            t8.Join();
            t9.Join();
        }

        public static void PrintList(List<int> list)
        {
            foreach (int element in list)
            {
                Console.WriteLine("TID: {0} => {1}", Thread.CurrentThread.ManagedThreadId, element);
            }
        }
    }
}
