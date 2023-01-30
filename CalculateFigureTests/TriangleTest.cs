using CalculateFigure;

namespace CalculateFigureTests
{
    internal class TriangleTest
    {
        
        [TestCase(4, 3, 5, 6)]
        [TestCase(3, 4, 6, 5.33)]
        [TestCase(111, 55, 62, 1024.33)]

        public void TriangleGetSquareTests(double x, double y, double z, double expected)
        {
            Triangle figure = new(x, y, z);
            var actual = Math.Round(figure.GetSquare(), 2);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(-4, 3, 5)]
        [TestCase(1, 12, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(12, 4, 45)]
        public void TriangleGetSquareNegativeTests(double x, double y, double z)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(x, y, z));
        }


        [TestCase(3, 4, 5, true)]
        [TestCase(25, 7, 24, true)]
        public void IsRectangularTests(double x, double y, double z, bool expected)
        {
            Triangle figure = new(x, y, z);
            var actual = figure.IsRectangular();
            Assert.AreEqual(expected, actual);
        }
    }
}
