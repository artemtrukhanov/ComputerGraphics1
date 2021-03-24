using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class HorizontalWaveFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double l = y;
            double k = x - 20 * Math.Sin((2 * 3.14 * y) / 60);
            sourceColor = sourceImage.GetPixel(Clamp((int)k, 0, sourceImage.Width - 1), (int)l);
            return sourceColor;
        }
    }

}
