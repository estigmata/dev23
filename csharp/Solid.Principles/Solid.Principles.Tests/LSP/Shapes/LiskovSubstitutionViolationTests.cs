using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid.Principles.LSPViolation.Shapes;

namespace Solid.Principles.Tests.LSP.Shapes
{
    [TestClass]
    public class LiskovSubstitutionViolationTests
    {
        [TestMethod]
        public void RectangleTest()
        {
            var rectangle = new Rectangle();
            rectangle.Height = 5;
            rectangle.Width = 4;

            Assert.AreEqual(5, rectangle.Height);
            Assert.AreEqual(20, rectangle.GetArea());
        }

        [TestMethod]
        public void SquareViolationTest()
        {
            var square = new Square();
            square.Height = 5;
            square.Width = 4;

            Assert.AreEqual(5, square.Height);
            Assert.AreEqual(20, square.GetArea());
        }
    }
}
