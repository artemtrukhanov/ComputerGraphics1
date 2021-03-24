using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    // Фильтр "Серый мир"
    class GrayWorld : Filters
    {
        double Avg = 0, _R = 0, _G = 0, _B = 0;

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor;
            if (Avg == 0)
            {
                for (int i = 0; i < sourceImage.Width; i++)
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        sourceColor = sourceImage.GetPixel(i, j);
                        _R += sourceColor.R;
                        _G += sourceColor.G;
                        _B += sourceColor.B;
                    }
                Avg = (_R + _G + _R) / 3;
            }
            sourceColor = sourceImage.GetPixel(x, y);
            double resultR = sourceColor.R * (Avg / _R);
            double resultG = sourceColor.G * (Avg / _G);
            double resultB = sourceColor.B * (Avg / _B);
            Color resultColor = Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
            return resultColor;
        }
    }
}
