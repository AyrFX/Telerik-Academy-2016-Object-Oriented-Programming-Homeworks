namespace PointsDemo
{
    using System;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePathToFile(Path path, string filename)
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                foreach (Point3D point in path.points)
                {
                    file.WriteLine(string.Format("{0}, {1}, {2}", point.x, point.y, point.z));
                }
            }
        }

        public static Path LoadPathFromFile(string filename)
        {
            using (StreamReader file = new StreamReader(filename))
            {
                Path path = new Path();
                string line = file.ReadLine();
                
                while (line != null)
                {
                    string[] coordinates = line.Split(',');
                    path.points.Add(new Point3D(int.Parse(coordinates[0]), int.Parse(coordinates[1]), int.Parse(coordinates[2])));
                    line = file.ReadLine();
                }
                file.Close();
                return path;
            }
        }
    }
}
