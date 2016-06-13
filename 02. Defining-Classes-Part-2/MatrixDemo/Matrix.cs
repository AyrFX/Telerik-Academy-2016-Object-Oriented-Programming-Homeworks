namespace MatrixDemo
{
    using System;

    public class Matrix<T>
        where T : struct,
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        private bool InMatrix(int row, int col)
        {
            if (row < 0 || row > this.matrix.GetLength(0) - 1 || col < 0 || col > this.matrix.GetLength(1) - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetLength(byte dimension)
        {
            if (dimension == 0)
            {
                return this.matrix.GetLength(0);
            }
            else if (dimension == 1)
            {
                return this.matrix.GetLength(1);
            }
            else
            {
                throw new ArgumentException("Given dimension is out of range!");
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (InMatrix(row, col))
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("The given index is out of range of the matrix!");
                }
            }
            set
            {
                if (InMatrix(row, col))
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The given index is out of range of the matrix!");
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> aNumber, Matrix<T> bNumber)
        {
            if (aNumber.GetLength(0) != bNumber.GetLength(0) || aNumber.GetLength(1) != bNumber.GetLength(1))
            {
                throw new ArgumentException("The matrices should be the same size!");
            }
            Matrix<T> newMatrix = new Matrix<T>(aNumber.GetLength(0), aNumber.GetLength(1));
            for (int i = 0; i < newMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = aNumber[i, j] + bNumber[i, j];
                }
            }
            return newMatrix;
        }
    }
}
