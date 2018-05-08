using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageIntegratedQuery.QueryTypes;

namespace Linq.Tests
{
    [TestClass]
    public class QuerySyntaxTests
    {
        [TestMethod]
        public void TestQuery1()
        {
            var querySyntax = new QuerySyntax();
            var query = querySyntax.GetQuery1();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void TestQuery2()
        {
            var querySyntax = new QuerySyntax();
            var query = querySyntax.GetQuery2();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
