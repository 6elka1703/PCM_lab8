using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class LinearSystem
    {
        public int size = 3;
        public int counterIter = 0; // Количество итераций
        public double eps = 0.001;
        public double[,] Matrix; // Изначальная матрица
        public double[] FreeTerms; // Свободные коэффициенты
        public double[,] A; // Преобразовання матрица
        public double[] X; // Матрица корней
        public double[] TempX; // Матрица временных корней

        public LinearSystem(int size, double eps, double[,] matrix, double[] freeTerms)
        {
            this.size = size;
            this.eps = eps;
            this.Matrix = matrix;
            this.FreeTerms = freeTerms;
            
            A = new double[size, size];
            X = new double[size];
            TempX = new double[size];

            // Преобразуем матрицу в нужный вид по методу Якоби.
            transformMatrix();

            // Зададим вектор начального приближения X
            FreeTerms.CopyTo(X, 0);
        }

        public void transformMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                FreeTerms[i] = FreeTerms[i] / Matrix[i, i];
                for (int j = 0; j < size; j++)
                {
                    if (i != j)
                        A[i, j] = -Matrix[i, j] / Matrix[i, i];
                    else
                        A[i, j] = 0;

                }
            }
        }

        public bool diagonal()
        {
            int i, j, k = 1;
            double sum;
            for (i = 0; i < size; i++)
            {
                sum = 0;
                for (j = 0; j < size; j++) sum += Math.Abs(Matrix[i, j]);
                sum -= Math.Abs(Matrix[i, i]);
                if (sum > Matrix[i, i])
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public double norma()
        {
            double norma = 0;
            for (int i = 0; i < size; i++)
            {
                double sumRow = 0;
                for (int j = 0; j < size; j++)
                {
                    sumRow += A[i, j];
                }

                norma = Math.Max(norma, Math.Abs(sumRow));
            }

            return norma;
        }

        public void Jacobi()
        {
            double norm = 0;
            do
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        TempX[i] += A[i, j] * X[j];
                    }

                    TempX[i] += FreeTerms[i];
                }

                double tempNorm = 0;

                norm = Math.Abs(TempX[0] - X[0]);
                for (int i = 0; i < size; i++)
                {
                    tempNorm = Math.Abs(TempX[i] - X[i]);
                    if (tempNorm > norm)
                        norm = tempNorm;
                    X[i] = TempX[i];
                }
                Array.Clear(TempX, 0, TempX.Length);

                counterIter++;

            } while (norm > eps);

        }

        public void Zeidel()
        {
            double norm = 0;
            do
            {
                // Заполним матрицу предыдущих корней
                for (int i = 0; i < size; i++)
                    TempX[i] = X[i];

                for (int i = 0; i < size; i++)
                {
                    double var = 0;
                    for (int j = 0; j < size; j++)
                    {
                        var += A[i, j] * X[j];
                    }

                    X[i] = var + FreeTerms[i];
                }

                double tempNorm = 0;

                norm = Math.Abs(TempX[0] - X[0]);
                for (int i = 0; i < size; i++)
                {
                    tempNorm = Math.Abs(X[i] - TempX[i]);
                    if (tempNorm > norm)
                        norm = tempNorm;
                }

                counterIter++;

            } while (norm > eps);
        }
    }
}
