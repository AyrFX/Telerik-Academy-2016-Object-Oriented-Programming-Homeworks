namespace PointsDemo
{
    using System;

    class PointsDemo
    {
        static void Main()
        {
            Point3D point = new Point3D(3, 4, 5);

            Console.WriteLine(point);
            Console.WriteLine(new string('=', 20));

            Console.WriteLine(Point3D.GetStart);
            Console.WriteLine(new string('=', 20));

            Point3D anotherPoint = new Point3D(7, 9, 12);
            Console.WriteLine(PointsCalculations.Distance(point, anotherPoint));
            Console.WriteLine(new string('=', 20));

            Path myPath = new Path();
            myPath.points.Add(point);
            myPath.points.Add(anotherPoint);
            myPath.points.Add(new Point3D(4, 12, 7));
            foreach (var pointInPath in myPath.points)
            {
                Console.WriteLine(pointInPath);
            }
            Console.WriteLine(new string('=', 20));

            PathStorage.SavePathToFile(myPath, "..\\..\\PathInput.txt");
            Console.WriteLine(new string('=', 20));

            Path anotherPath = PathStorage.LoadPathFromFile("..\\..\\PathOutput.txt");
            foreach (var pointInPath in anotherPath.points)
            {
                Console.WriteLine(pointInPath);
            }
        }
    }
}
