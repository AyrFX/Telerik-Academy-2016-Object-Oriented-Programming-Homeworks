namespace Shapes
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateSurface() => (this.Height * this.Width) / 2;
    }
}
