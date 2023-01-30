using CalculateFigure.Interfaces;

namespace CalculateFigure
{
    public class Triangle : Figure, IRectangular
    {

        private double _x;
        private double _y;
        private double _z;


        public Triangle(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
            ValidateFigure();
        }
        public override double GetSquare()
        {
            if (Square == 0)
            {
                double p = GetPerim();

                Square = Math.Pow((p * (p - _x) * (p - _y) * (p - _z)), 0.5);
            }
            return Square;
        }

        public bool IsRectangular()
        {
            List<double> sides = new List<double> { _x, _y, _z };

            double hypo = sides.Max();
            sides.Remove(hypo);

            return hypo * hypo == sides[0] * sides[0] + sides[1] * sides[1];
        }

        protected override void ValidateFigure()
        {

            if ((_x <= 0 || _y <= 0 || _z <=0) || (GetSquare() is double.NaN))
                throw new ArgumentException("Invalid args");
        }

        private double GetPerim()
            => (_x + _y + _z) / 2.0;

    }
}
