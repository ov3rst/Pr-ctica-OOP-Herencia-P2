namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double height) : base(height, height) { }

        public override double CalculateSurface() => this._height * (2 * Math.PI);
    }
}
