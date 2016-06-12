namespace PointsDemo
{
    using System;

    static class PointsCalculations
    {
        public static double Distance(Point3D pointA, Point3D pointB)
        {
            double distance = Math.Pow(pointA.x - pointB.x, 2);
            distance += Math.Pow(pointA.y - pointB.y, 2);
            distance = Math.Pow(pointA.z - pointB.z, 2);
            return Math.Sqrt(distance);
        }
    }
}
