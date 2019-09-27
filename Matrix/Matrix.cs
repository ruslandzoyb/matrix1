using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix_model
    {
        private double[,] matrix;
        private ushort row, column;

        public Matrix_model(double[,] matrix,ushort i,ushort j)
        {
            if (i*j==matrix.Length )
            {
                try
                {
                    this.matrix = matrix;
                    Dimension(i, j);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        public Matrix_model(ushort i,ushort j)
        {
            Dimension(i, j);
        }
        private void Dimension(ushort i,ushort j)
        {
            row = i;
            column = j;
        }

        public double[,] Matrix
        {
            get
            {
                return this.matrix;
            }
        }

        public double this[ushort i,ushort j]
        {
            get
            {
                if (i<=row && j<=column)
                {
                    return this.matrix[i, j];
                }
                else
                {
                    throw new Exception("Выход за границы массива ");
                }
            }
        }

    }
}
