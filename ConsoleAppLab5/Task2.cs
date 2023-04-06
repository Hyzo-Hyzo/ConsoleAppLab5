using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab5
{
    using System;

    class Matrix
    {
        private int rows;
        private int cols;
        private int[,] data;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new int[rows, cols];
        }

        public int Rows
        {
            get { return rows; }
        }

        public int Cols
        {
            get { return cols; }
        }

        public int this[int i, int j]
        {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            Matrix result = new Matrix(m1.Rows, m1.Cols);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            Matrix result = new Matrix(m1.Rows, m1.Cols);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Cols != m2.Rows)
            {
                throw new ArgumentException("The number of columns in the first matrix must equal the number of rows in the second matrix.");
            }

            Matrix result = new Matrix(m1.Rows, m2.Cols);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Cols; j++)
                {
                    for (int k = 0; k < m1.Cols; k++)
                    {
                        result[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m, int scalar)
        {
            Matrix result = new Matrix(m.Rows, m.Cols);

            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Cols; j++)
                {
                    result[i, j] = m[i, j] * scalar;
                }
            }

            return result;
        }





        public static Matrix operator /(Matrix m1, Matrix m2)
        {
            if (m1.Cols != m2.Rows)
            {
                throw new ArgumentException("The number of columns in the first matrix must equal the number of rows in the second matrix.");
            }

            Matrix result = new Matrix(m1.Rows, m2.Cols);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Cols; j++)
                {
                    for (int k = 0; k < m1.Cols; k++)
                    {
                        result[i, j] += m1[i, k] / m2[k, j];
                    }
                }
            }

            return result;
        }

        public static Matrix operator /(Matrix m, int scalar)
        {
            Matrix result = new Matrix(m.Rows, m.Cols);

            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Cols; j++)
                {
                    result[i, j] = m[i, j] / scalar;
                }
            }

            return result;
        }

        public static void PrintMatrix(Matrix m)
        {
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Cols; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


