using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static void ExecuteSequentialForeach(IEnumerable<int> sourceCollection)
        {
            var itemCount = 0;
            var threadIds = new HashSet<int>();

            foreach (var item in sourceCollection)
            {
                Process(ref itemCount, threadIds);
            }

            Console.WriteLine($"Processed items: {itemCount}. Threads: {threadIds.Count}.");
        }

        public static void ExecuteParallelForeach(IEnumerable<int> sourceCollection)
        {
            var itemCount = 0;
            var threadIds = new HashSet<int>();

            //// Using anonymous method
            //Parallel.ForEach(sourceCollection, delegate (int item)
            //{
            //    Process(ref itemCount, threadIds);
            //});

            // Using lambda expression
            Parallel.ForEach(sourceCollection, item => Process(ref itemCount, threadIds));

            Console.WriteLine($"Processed items: {itemCount}. Threads: {threadIds.Count}.");
        }

        public static void ExecuteSequentialFor(IEnumerable<int> sourceCollection)
        {
            var itemCount = 0;
            var threadIds = new HashSet<int>();

            for (int i = 0; i < sourceCollection.Count(); i++)
            {
                Process(ref itemCount, threadIds);
            }

            Console.WriteLine($"Processed items: {itemCount}. Threads: {threadIds.Count}.");
        }

        public static void ExecuteParallelFor(IEnumerable<int> sourceCollection)
        {
            var itemCount = 0;
            var threadIds = new HashSet<int>();

            Parallel.For(0, sourceCollection.Count(), index => Process(ref itemCount, threadIds));

            Console.WriteLine($"Processed items: {itemCount}. Threads: {threadIds.Count}.");
        }

        public static void ExecuteSequentialForeach2(IEnumerable<int> sourceCollection)
        {
            var itemCount = 0;
            var threadIds = new HashSet<int>();

            foreach (var item in sourceCollection)
            {
                if (item == 1000)
                {
                    break;
                }

                Process(ref itemCount, threadIds);
            }

            Console.WriteLine($"Processed items: {itemCount}. Threads: {threadIds.Count}.");
        }

        public static void ExecuteParallelForeach2(IEnumerable<int> sourceCollection)
        {
            var itemCount = 0;
            var threadIds = new HashSet<int>();

            Parallel.ForEach(sourceCollection, (item, state) =>
            {
                if (item == 1000)
                {
                    state.Break();
                }

                Process(ref itemCount, threadIds);
            });
            Parallel.ForEach(
                sourceCollection,
                new ParallelOptions { MaxDegreeOfParallelism = 2 },

            );

            Console.WriteLine($"Processed items: {itemCount}. Threads: {threadIds.Count}.");
        }

        private static object lockObject = new object();

        private static void Process(ref int itemCount, HashSet<int> threadIds)
        {
            lock (lockObject)
            {
                itemCount++;
            }
            
            threadIds.Add(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
