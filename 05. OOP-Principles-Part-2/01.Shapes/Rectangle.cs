using System;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }
        public override double CalculateSurface() => this.Height * this.Width;
    }
}
