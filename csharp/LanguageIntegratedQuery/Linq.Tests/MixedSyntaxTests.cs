using LanguageIntegratedQuery.QueryTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Tests
{
    [TestClass]
    public class MixedSyntaxTests
    {
        [TestMethod]
        public void TestQuery1()
        {
            var methodSyntax = new MixedSyntax();
            methodSyntax.ExecuteQuery1();
        }

        [TestMethod]
        public void TestQuery2()
        {
            var methodSyntax = new MixedSyntax();
            methodSyntax.ExecuteQuery2();
        }
    }
}
