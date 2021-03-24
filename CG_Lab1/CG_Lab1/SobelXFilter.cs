using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    // Фильтр Собеля по оси X
    class SobelXFilter : MatrixFilter
    {
        public SobelXFilter()
        {
            kernel = new float[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        }
    }
}
