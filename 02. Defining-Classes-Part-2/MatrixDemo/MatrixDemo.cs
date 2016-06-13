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

            Console.WriteLine("First matrix:");
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    Console.Write(someMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('=', 21));

            Console.WriteLine("Second matrix:");
            Matrix<int> anotherMatrix = new Matrix<int>(4, 4);
            anotherMatrix[0, 3] = 3;
            anotherMatrix[1, 2] = 3;
            anotherMatrix[2, 1] = 3;
            anotherMatrix[3, 0] = 3;

            for (int i = 0; i < anotherMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < anotherMatrix.GetLength(1); j++)
                {
                    Console.Write(anotherMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('=', 21));

            Matrix<int> additionMatrix = someMatrix + anotherMatrix;
            Console.WriteLine("Addition: ");
            for (int i = 0; i < additionMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < additionMatrix.GetLength(1); j++)
                {
                    Console.Write(additionMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('=', 21));
        }

    }
}
