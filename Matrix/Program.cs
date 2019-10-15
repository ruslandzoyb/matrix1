using System;
using System.Collections.Generic;
using Matrix;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                Matrix matrix = new Matrix(new[,] { { 1.0, 2, 3 }, { 4, 8, 9 } }, 2, 3);
                Matrix matrix2 = new Matrix(new[,] { { 1.0, 1 }, { 1, 4 }, { 6, 7 } }, 3, 2);
                matrix.Show_Matrix();
                Console.WriteLine();

               // Matrix mat = Matrix.Load();

                matrix.Show_Matrix();

                matrix2.Save();

                List<Matrix> matrices = matrix.Deserilize();

                foreach (var item in matrices)
                {
                    Console.WriteLine("");
                    item.Show_Matrix();
                }
                

               

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
