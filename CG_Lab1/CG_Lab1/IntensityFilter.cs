using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    // Фильтр, уыеличивающий яркость изображения
    class IntensityFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double k = 51.2;
            double resultR = sourceColor.R + k;
            double resultG = sourceColor.G + k;
            double resultB = sourceColor.B + k;
            Color resultColor = Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
            return resultColor;
        }
    }
}
