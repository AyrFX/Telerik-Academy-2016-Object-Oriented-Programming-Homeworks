namespace PointsDemo
{
    public struct Point3D
    {
        public int x;
        public int y;
        public int z;

        private static Point3D startCoordinates;

        public static Point3D GetStart
        {
            get
            {
                return startCoordinates;
            }
        }

        public Point3D(int xCoordinate, int yCoordinate, int zCoordinate)
        {
            this.x = xCoordinate;
            this.y = yCoordinate;
            this.z = zCoordinate;
            startCoordinates = new Point3D();
            startCoordinates.x = 0;
            startCoordinates.y = 0;
            startCoordinates.z = 0;
        }

        public override string ToString()
        {
            return string.Format("\xff5b{0}, {1}, {2}\xff5d", this.x, this.y, this.z);
        }
    }
}
