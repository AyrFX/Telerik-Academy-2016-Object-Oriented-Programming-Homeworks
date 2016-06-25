namespace Shapes
{
    using System;

    public abstract class Shape
    {
        public abstract double CalculateSurface();

        public double Width { get; set; }
        public double Height { get; set; }
    }
}
