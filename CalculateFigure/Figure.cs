namespace CalculateFigure
{
    public abstract class Figure
    {
        public abstract double GetSquare();

        protected double Square;

        /// <summary>
        /// Check is valid arguments
        /// </summary>
        protected abstract void ValidateFigure();
    }
}
