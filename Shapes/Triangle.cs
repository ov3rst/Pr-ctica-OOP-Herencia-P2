namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width) : base(height, width)
        {

        }

        public override double CalculateSurface() => this._height * this._width / 2;
    }
}
