using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class PrewittYFilter : MatrixFilter
    {
        public PrewittYFilter()
        {
            kernel = new float[,] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
        }
    }
}
