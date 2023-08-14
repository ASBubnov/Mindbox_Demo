using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestShape.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateAreaTest_Circle()
        {
            var circle = new Circle(20);
            const double expected = 1256.6370614359173d;
            Assert.AreEqual(expected, circle.Area);
        }

        [TestMethod]
        public void CalculateAreaTest_Triangle()
        {
            var triangle = new Triangle(12,12,9);
            const double expected = 50.05933978789572d;
            Assert.AreEqual(expected, triangle.Area);
        }

        [DataRow(12, 10, 9, false)]
        [DataRow(12, 12, 9, true)]
        [TestMethod]
        public void CalculateAreaTest_TriangleIsIsosceles(double a, double b, double c, bool expected)
        {
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(expected, triangle.IsIsosceles);
        }
    }
}