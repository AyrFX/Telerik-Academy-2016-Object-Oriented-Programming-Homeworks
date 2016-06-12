namespace PointsDemo
{
    using System.Collections.Generic;

    public class Path
    {
        public List<Point3D> points { get; set; }

        public Path()
        {
            this.points = new List<Point3D>();
        }
    }
}
