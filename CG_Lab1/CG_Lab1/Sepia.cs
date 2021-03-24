using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    // Фильтр "Сепия"
    class Sepia : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
            double k = 15.2;
            double resultR = intensity + 2 * k;
            double resultG = intensity + 0.5 * k;
            double resultB = intensity - 1 * k;
            Color resultColor = Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
            return resultColor;
        }
    }
}
