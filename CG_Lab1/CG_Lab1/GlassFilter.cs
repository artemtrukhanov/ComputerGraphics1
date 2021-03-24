using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class GlassFilter : Filters
    {
        static Random rand = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int k = (int)(x - (rand.Next(2) - 0.5) * 10);
            int l = (int)(y - (rand.Next(2) - 0.5) * 10);
            Color resultColor = sourceImage.GetPixel(Clamp(k, 0, sourceImage.Width - 1),
                                                     Clamp(l, 0, sourceImage.Height - 1));
            return resultColor;
        }
    }
}
