namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int height, int width) : base(height, width)
        {

        }

        public override double CalculateSurface() => this._height * this._width;
    }
}
