using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{

    public class Matrix<T>
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rowCout, int colCount)
        {
            this.rows = rowCout;
            this.cols = colCount;
            this.matrix = new T[rowCout, colCount];
        }
        public int Rows
        {
            get
            {
                return rows;
            }
            set
            {
                this.Rows = value;
            }
        }
        public int Cols
        {
            get
            {
                return cols;
            }
            set
            {
                this.Cols = value;
            }
        }
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
            }
        }
        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
            {
                throw new Exception("Addition is not allowed on matrices with different sizes.");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic)a[row, col] + b[row, col];
                }
            }

            return result;
        }
        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
            {
                throw new Exception("Subtraction is not allowed on matrices with different sizes.");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic)a[row, col] - b[row, col];
                }
            }

            return result;
        }
        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Rows)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }
            Matrix<T> result = new Matrix<T>(a.Rows, b.Cols);
            T temp;
            for (int k  = 0; k < result.Rows; k++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    temp = (dynamic)0;
                    for (int index = 0; index < result.Cols; index++)
                    {
                        temp += (dynamic)a[k, index] * b[index, j];
                    }
                    result[k, j] = (dynamic)temp;
                }
            }
            return result;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
