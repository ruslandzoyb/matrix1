using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Controller
    {
        List<Matrix> matrices;

        public  Controller()
        {
            
        }
        public Matrix GetMatrix(double[,] arr)
        {

            return new Matrix((double[,])arr.Clone());

        }



        public List<Matrix> Deserilize()
        {
            SerializeSaver serializeSaver = new SerializeSaver();

            return serializeSaver.Load<Matrix>();

            
        }

       

    }
}
