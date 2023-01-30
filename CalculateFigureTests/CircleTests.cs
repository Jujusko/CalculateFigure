using CalculateFigure;

namespace CalculateFigureTests
{
    internal class CircleTests
    {
        [TestCase(1, 3.14)]
        [TestCase(92, 26590.44)]
        public void CircleGetSquareTests(double radius, double expected)
        {
            Circle figure = new(radius);
            var actual = Math.Round(figure.GetSquare(), 2);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(-4)]
        [TestCase(-12)]
        [TestCase(0)]
        public void CIrcleGetSquareNegativeTests(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
