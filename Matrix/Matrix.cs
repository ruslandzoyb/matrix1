using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Matrix
{  [Serializable]
   public class Matrix
    {
        private double[,] matrix;
        private ushort row, column;
        List<Matrix> matrixs;

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

        
      

        public static Matrix operator +(Matrix first, Matrix second)
        {
            return Addition(first, second);
        }
        public static Matrix operator -(Matrix first, Matrix second)
        {
            return Substraction(first, second);
        }
        public static Matrix operator * (Matrix first,Matrix second)
        {
            return Multiplication(first, second);
        }

        public static Matrix Addition(Matrix first, Matrix second)
        {

            if (first.Row == second.Row && first.Column == second.Column)
            {
                Matrix matrix = new Matrix(first.Row, first.Column);
                for (ushort i = 0; i < first.Row; i++)
                {
                    for (ushort j = 0; j < first.Column; j++)
                    {
                        matrix[i, j] = first[i, j] + second[i, j];
                    }
                }
                return matrix;
            }
            else
            {
                throw new Exception("Неравные матрицы ");
            }
        }
        public static Matrix Substraction(Matrix first, Matrix second)
        {
            if (first.Row == second.Row && first.Column == second.Column)
            {
                Matrix matrix = new Matrix(first.Row, first.Column);
                for (ushort i = 0; i < first.Row; i++)
                {
                    for (ushort j = 0; j < first.Column; j++)
                    {
                        matrix[i, j] = first[i, j] - second[i, j];
                    }
                }
                return matrix;
            }
            else
            {
                throw new Exception("Не равные матрицы ");
            }
        }
        public static Matrix Multiplication(Matrix first, Matrix second)
        {

            if (first.Column == second.Row)
            {
                Matrix matrix = new Matrix(first.Row, second.Column);
                for (ushort i = 0; i < first.Row; i++)
                {
                    for (ushort j = 0; j < second.Column; j++)
                    {
                        matrix[i, j] = 0;

                        for (ushort k = 0; k < first.Column; k++)
                        {
                            matrix[i, j] += first[i, k] * second[k, j];
                        }
                    }

                }
                return matrix;
            }
            else
            {
                throw new Exception("");
            }
        }
        public  void Save()
        {
            if (this == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }
            Deserilize();
            matrixs.Add(this);

            SerializeSaver saver = new SerializeSaver();
            saver.Save<Matrix>(matrixs);
            
        


        }
        public List<Matrix> Deserilize()
        {
            SerializeSaver load = new SerializeSaver();

           return matrixs = load.Load<Matrix>();
        }
       

        /* public object Clone()
         {
             return new Matrix(this.Matr, this.Row, this.Column);
         }*/


    }
}
