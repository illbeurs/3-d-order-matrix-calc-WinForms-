using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summer_practice
{
    // Матрицы размера 3x3
    public class Matrix
    {
        private double[,] mtx = new double[3, 3];

        // Создание матрицы с рандомным заполнением
        public Matrix()
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    mtx[i, j] = r.Next(1, 5);
        }
        // Нулевая матрица
        public Matrix(char f)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    mtx[i, j] = 0;
        }
        public void print()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mtx[i, j]);
                    Console.Write(' ');

                }
                Console.WriteLine();
            }
        }
        // Создадим индексатор для удобного обращения с матрицами 
        public double this[int i, int j]
        {
            get => mtx[i, j];
            set => mtx[i, j] = value;
        }


        // Вычисление определителя
        public double det()
        {
            return (mtx[0, 0] * mtx[1, 1] * mtx[2, 2]) + (mtx[1, 0] * mtx[2, 1] * mtx[0, 2]) + (mtx[0, 1] * mtx[1, 2] * mtx[2, 0]) -
            (mtx[0, 2] * mtx[1, 1] * mtx[2, 0]) - (mtx[2, 1] * mtx[1, 2] * mtx[0, 0]) - (mtx[0, 1] * mtx[1, 0] * mtx[2, 2]);
        }

        // Далее реализуем бинарные операции над матрицами
        private static Matrix plus(Matrix A, Matrix B)
        {
            Matrix res = new Matrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res[i, j] = A[i, j] + B[i, j];
                }
            }
            return res;
        }
        private static Matrix minus(Matrix A, Matrix B)
        {
            Matrix res = new Matrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res[i, j] = A[i, j] - B[i, j];
                }
            }
            return res;
        }
        private static Matrix multM(Matrix A, Matrix B)
        {
            double elem = 0;
            Matrix res = new Matrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        elem += (A[i, k] * B[k, j]);
                    }
                    res[i, j] = elem;
                    elem = 0;
                }
            }
            return res;
        }
        private static Matrix multS(double scalar, Matrix A)
        {
            Matrix res = new Matrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res[i, j] = scalar * A[i, j];
                }
            }
            return res;
        }

        // Теперь перегрузим соответствующие операторы
        public static Matrix operator *(Matrix A, Matrix B)
        {
            return multM(A, B);
        }
        public static Matrix operator *(double s, Matrix B)
        {
            return multS(s, B);
        }
        public static Matrix operator *(Matrix B, double s)
        {
            return multS(s, B);
        }
        public static Matrix operator +(Matrix A, Matrix B)
        {
            return plus(A, B);
        }
        public static Matrix operator -(Matrix A, Matrix B)
        {
            return minus(A, B);
        }

    }
}
