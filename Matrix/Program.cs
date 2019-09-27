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
            matrix.Show_Matrix();

            Console.ReadKey();
        }
    }
}
