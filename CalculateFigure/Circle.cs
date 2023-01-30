namespace CalculateFigure
{
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
            ValidateFigure();
        }

        public override double GetSquare()
        {
            return Math.PI * _radius * _radius;
        }

        protected override void ValidateFigure()
        {
            if (_radius <= 0)
                throw new ArgumentException("Radius can't being less than zero");
        }

    }
}
