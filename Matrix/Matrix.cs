using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Matrix
{  [Serializable]
   public class Matrix: ICloneable
    {
        private double[,] matrix;
        private int row, column;
        private List<Matrix> matrixs;

        public Matrix(double[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            else
            {
                this.matrix =(double[,])matrix.Clone();
                Dimension(matrix.GetLength(0), matrix.GetLength(1));
            }
            
            
           

        }
        public Matrix(int i,int j)
        {
            if (i>0&&j>0)
            {
                this.matrix = new double[i, j];
                Dimension(i, j);
            }
            else
            {
                throw new Exception("Отрицательные индексы");
            }
           
        }
        private void Dimension(int i,int j)
        {
            row = i;
            column = j;
        }
        
       
        public int Row
        {
            get
            {
                return row;
            }
        }
        public int Column
        {
            get
            {
                return column;
            }
        }

        public double this[int i,int j]
        {
            get
            {
                if ((i<=row && j<=column)||(i>0 && j>0))
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
                if ((i <= row && j <= column) || (i > 0 && j > 0))
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
            Console.WriteLine("");
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
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Column; j++)
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
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Column; j++)
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
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < second.Column; j++)
                    {
                        matrix[i, j] = 0;

                        for (int k = 0; k < first.Column; k++)
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
        public void Serialize()
        {
            if (this==null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                SerializeSaver serializeSaver = new SerializeSaver();
                List<Matrix> matrices = serializeSaver.Load<Matrix>();
                matrices.Add(this);
                serializeSaver.Save<Matrix>(matrices);

            }
         
        }

        public object Clone()
        {
            double[,] array =(double[,])matrix.Clone();
            return new Matrix(array);
        }


       


    }
}
