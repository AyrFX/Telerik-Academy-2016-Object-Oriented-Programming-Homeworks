namespace MatrixDemo
{
    using System;

    class MatrixDemo
    {
        static void Main()
        {
            Matrix<int> someMatrix = new Matrix<int>(4, 4);
            someMatrix[0, 0] = 3;
            someMatrix[1, 1] = 3;
            someMatrix[2, 2] = 3;
            someMatrix[3, 3] = 3;

            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    Console.Write(someMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('=', 21));

            Matrix<int> anotherMatrix = new Matrix<int>(4, 4);
            someMatrix[0, 3] = 3;
            someMatrix[1, 2] = 3;
            someMatrix[2, 1] = 3;
            someMatrix[3, 0] = 3;

            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    Console.Write(someMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('=', 21));

            Matrix<int> addition = someMatrix + anotherMatrix;
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    Console.Write(someMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('=', 21));
        }

    }
}
