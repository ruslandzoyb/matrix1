using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(new[,] { { 1.0, 2, 3 }, { 4, 8, 9 } }, 2, 3);
            Matrix matrix2 = new Matrix(new[,] { { 1.0, 1}, { 1 , 4 }, { 6,7}  }, 3, 2);
            matrix.Show_Matrix();
            Console.WriteLine();
            matrix2.Show_Matrix();
            Console.WriteLine();
            Matrix mat = matrix * matrix2;
            mat.Show_Matrix();
            //Operations.Serialize(mat);
            Matrix m = Operations.Deserilize();
            m.Show_Matrix();

            Console.ReadKey();
        }
    }
}
