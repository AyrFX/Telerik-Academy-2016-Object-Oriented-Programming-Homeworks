namespace MatrixDemo
{
    using System;

    class MatrixDemo
    {
        static void Main()
        {
            Matrix<int> someMatrix = new Matrix<int>(5, 5);
            someMatrix[0, 0] = 3;
            someMatrix[1, 1] = 3;
            someMatrix[2, 2] = 3;
            someMatrix[3, 3] = 3;
            someMatrix[4, 4] = 3;

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
            Matrix<int> anotherMatrix = new Matrix<int>(5, 5);
            anotherMatrix[0, 4] = 4;
            anotherMatrix[1, 3] = 4;
            anotherMatrix[2, 2] = 4;
            anotherMatrix[3, 1] = 4;
            anotherMatrix[4, 0] = 4;

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

            Matrix<int> subtractionMatrix = someMatrix - anotherMatrix;
            Console.WriteLine("Subtraction: ");
            for (int i = 0; i < subtractionMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < subtractionMatrix.GetLength(1); j++)
                {
                    Console.Write(subtractionMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('=', 21));

            Matrix<int> multiplicationMatrix = someMatrix * anotherMatrix;
            Console.WriteLine("Multiplication: ");
            for (int i = 0; i < multiplicationMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < multiplicationMatrix.GetLength(1); j++)
                {
                    Console.Write(multiplicationMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('=', 21));
        }

    }
}