namespace Shapes
{
    class Startup
    {
        static void Main()
        {
            Shape[] shapesArray = { new Triangle(12.4, 4.7),
                new Triangle(3.4, 4.12),
                new Triangle(7.3, 3.4),
                new Rectangle(12.4, 4.7),
                new Rectangle(3.4, 4.12),
                new Rectangle(7.3, 3.4),
                new Square(12.4),
                new Square(3.4),
                new Square(7.3)
                };

            foreach (var element in shapesArray)
            {
                System.Console.Write(element.GetType().Name + ": ");
                System.Console.WriteLine(element.CalculateSurface());
            }
        }
    }
}
