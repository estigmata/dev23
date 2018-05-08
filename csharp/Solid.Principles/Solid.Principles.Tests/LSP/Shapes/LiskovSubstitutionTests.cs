using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid.Principles.LSP.Shapes;

namespace Solid.Principles.Tests.LSP.Shapes
{
    [TestClass]
    public class LiskovSubstitutionTests
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
            square.Side = 5;

            Assert.AreEqual(25, square.GetArea());
        }
    }
}
