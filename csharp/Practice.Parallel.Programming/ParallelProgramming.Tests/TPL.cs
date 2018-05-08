using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ParallelProgramming.Tests
{
    [TestClass]
    public class TPL
    {
        private static IEnumerable<int> forCollection;
        private static IEnumerable<int> foreachCollection;

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            forCollection = Enumerable.Range(0, 10000);
            foreachCollection = Enumerable.Range(0, 100000);
        }

        [TestMethod]
        public void SequentialForeach2()
        {
            Program.ExecuteSequentialForeach2(foreachCollection);
        }

        [TestMethod]
        public void ParallelForeach2()
        {
            Program.ExecuteParallelForeach2(foreachCollection);
        }
    }
}
