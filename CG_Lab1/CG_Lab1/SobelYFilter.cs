using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    // Фильтр Собеля по оси Y
    class SobelYFilter : MatrixFilter
    {
        public SobelYFilter()
        {
            kernel = new float[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
        }
    }
}
