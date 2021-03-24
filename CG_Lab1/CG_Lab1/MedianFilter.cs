using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class MedianFilter : Filters
    {
        protected int radius;

        public MedianFilter(int radius)
        {
            this.radius = radius;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int minRad = -(radius / 2);
            int plusRad = radius / 2;

            List<int> Rs = new List<int>();
            List<int> Gs = new List<int>();
            List<int> Bs = new List<int>();

            for(int l = minRad; l < plusRad; l++)
            {
                int yy = y + l;
                if(yy >= 0 && yy < sourceImage.Height)
                {
                    for(int k = minRad; k < plusRad; k++)
                    {
                        int xx = x + k;
                        if(xx >= 0 && xx < sourceImage.Width)
                        {
                            Rs.Add(sourceImage.GetPixel(xx, yy).R);
                            Gs.Add(sourceImage.GetPixel(xx, yy).G);
                            Bs.Add(sourceImage.GetPixel(xx, yy).B);
                        }
                    }
                }
            }
            Rs.Sort();
            Gs.Sort();
            Bs.Sort();

            Color resulColor = Color.FromArgb(Rs[Rs.Count / 2], Gs[Gs.Count / 2], Bs[Bs.Count / 2]);
            return resulColor;
        }
    }
}
