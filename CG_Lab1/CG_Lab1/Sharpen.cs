using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    // Фильтр, повышающий резкость изображения
    class Sharpen : MatrixFilter
    {
        public Sharpen()
        {
            kernel = new float[,] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
        }
    }
}
