using Shapes;

Shape[] shapes =
    [
        new Rectangle(45,67),
        new Triangle(50, 60),
        new Circle(56)
    ];

double[] surfaces = new double[shapes.Length];

for (int i = 0; i < shapes.Length; i++)
{
    surfaces[i] = Math.Round(shapes[i].CalculateSurface(), 2);
    Console.WriteLine(surfaces[i]);
}

Console.ReadKey(true);