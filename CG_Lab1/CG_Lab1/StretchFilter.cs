using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    // Линейное растяжение гистограммы
    class StretchFilter : Filters
    {
        double Rmin = -1, Gmin = -1, Bmin = -1;
        double Rmax = 0, Gmax = 0, Bmax = 0;

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color tmp;
            if (Rmin == -1 && Gmin == -1 && Bmin == -1)
            {
                Rmin = sourceColor.R;
                Gmin = sourceColor.G;
                Bmin = sourceColor.B;
                for (int i = 0; i < sourceImage.Width; i++)
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        tmp = sourceImage.GetPixel(i, j);
                        if (Rmin > tmp.R) Rmin = tmp.R;
                        if (Gmin > tmp.G) Gmin = tmp.G;
                        if (Bmin > tmp.B) Bmin = tmp.B;
                        if (Rmax < tmp.R) Rmax = tmp.R;
                        if (Gmax < tmp.G) Gmax = tmp.G;
                        if (Bmax < tmp.B) Bmax = tmp.B;
                    }
            }
            //double intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
            //double resultR = ((intensity - Rmin) * 255) / (Rmax - Rmin);
            //double resultG = ((intensity - Gmin) * 255) / (Gmax - Gmin);
            //double resultB = ((intensity - Bmin) * 255) / (Bmax - Bmin);
            double resultR = (sourceColor.R - Rmin) * (255 / (Rmax - Rmin));
            double resultG = (sourceColor.G - Gmin) * (255 / (Gmax - Gmin));
            double resultB = (sourceColor.B - Bmin) * (255 / (Bmax - Bmin));
            Color resultColor = Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
            return resultColor;
        }
    }
}
