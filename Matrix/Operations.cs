using System;


namespace Matrix
{
    class Operations
    {
       public static Matrix Addition(Matrix first,Matrix second)
        {
           
            if (first.Row==second.Row && first.Column==second.Column)
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
                throw new Exception("Не равные матрицы ");
            }
        }
       public static Matrix Substraction (Matrix first,Matrix second)
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


    }
}
