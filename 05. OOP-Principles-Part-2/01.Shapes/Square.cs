using System;

namespace Shapes
{
    class Square : Shape
    {
        public Square(double width)
        {
            this.Height = width;
            this.Width = width;
        }

        public override double CalculateSurface() => this.Height * this.Width;
    }
}
