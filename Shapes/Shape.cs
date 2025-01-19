namespace Shapes
{
    public abstract class Shape
    {
        protected double _height, _width;

        protected Shape(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public abstract double CalculateSurface();
    }
}
