using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageIntegratedQuery.QueryTypes;

namespace Linq.Tests
{
    [TestClass]
    public class MethodSyntaxTests
    {
        [TestMethod]
        public void TestQuery1()
        {
            var methodSyntax = new MethodSyntax();
            methodSyntax.ExecuteQuery1();
        }

        [TestMethod]
        public void TestQuery2()
        {
            var methodSyntax = new MethodSyntax();
            methodSyntax.ExecuteQuery2();
        }

        public void TestQuery3()
        {
            var methodSyntax = new MethodSyntax();
            methodSyntax.ExecuteQuery3();
        }
    }
}
