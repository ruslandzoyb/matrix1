﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        private double[,] matrix;
        private ushort row, column;

        public Matrix(double[,] matrix,ushort i,ushort j)
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
            else
            {
                throw new Exception("Несоответсвие индексов и массива");
            }

        }
        public Matrix(ushort i,ushort j)
        {
            this.matrix = new double[i, j];
            Dimension(i, j);
        }
        private void Dimension(ushort i,ushort j)
        {
            row = i;
            column = j;
        }

        public double[,] Matr
        {
            get
            {
                return this.matrix;
            }
        }
        public ushort Row
        {
            get
            {
                return row;
            }
        }
        public ushort Column
        {
            get
            {
                return column;
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
            set
            {
                if (i<=row && j<=column)
                {

                    this.matrix[i, j] = value;
                }
            }
        }

        public void Show_Matrix()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(this.matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

    }
}
