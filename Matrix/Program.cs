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
                Controller controller = new Controller();
                var matr1 = controller.GetMatrix(new[,] { { 1.0, 2, 3 }, { 4, 8, 9 } });
                var matr2 = controller.GetMatrix(new[,] { { 1.0, 1 }, { 1, 4 }, { 6, 7 } });
                matr1.Show_Matrix();
                matr2.Show_Matrix();
                // Matrix matrix = new Matrix(new[,] { { 1.0, 2, 3 }, { 4, 8, 9 } });
                // Matrix matrix2 = new Matrix(new[,] { { 1.0, 1 }, { 1, 4 }, { 6, 7 } }, 3, 2);
                matr1.Serialize();
                matr2.Serialize();

                var list = controller.Deserilize();

                foreach (var item in list)
                {
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
