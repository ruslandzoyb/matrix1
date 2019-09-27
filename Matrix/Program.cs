using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(new[,] { { 1.0, 2, 3 }, { 4, 8, 9 } }, 2, 3);
            Matrix matrix2 = new Matrix(new[,] { { 1.0, 1, 7 }, { 0, 4, 2 } }, 2, 3);
            matrix.Show_Matrix();
            Console.WriteLine();
            matrix2.Show_Matrix();
            Console.WriteLine();
            Matrix mat = Operations.Addition(matrix, matrix2);
            mat.Show_Matrix();

            Console.ReadKey();
        }
    }
}
