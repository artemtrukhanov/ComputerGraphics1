using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class Dilation : MathMorfology
    {
        public Dilation(int[,] mask)
        {
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            int mh = mask.GetUpperBound(0) + 1;
            int mw = mask.Length / mh;

            for (int y = mh/2; y < sourceImage.Height - mh/2; y++)
            {
                worker.ReportProgress((int)((float)y / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;

                for (int x = mw / 2; x < sourceImage.Width - mw / 2; x++)
                {
                    int maxR = 0;
                    int maxG = 0;
                    int maxB = 0;
                    for (int j = -mh / 2; j <= mh / 2; j++)
                        for (int i = -mw / 2; i <= mw / 2; i++)
                            if (mask[mw / 2 + i, mh / 2 + j] == 1)
                            {
                                if (sourceImage.GetPixel(x + i, y + j).R > maxR)
                                    maxR = sourceImage.GetPixel(x + i, y + j).R;
                                if (sourceImage.GetPixel(x + i, y + j).G > maxG)
                                    maxG = sourceImage.GetPixel(x + i, y + j).G;
                                if (sourceImage.GetPixel(x + i, y + j).B > maxB)
                                    maxB = sourceImage.GetPixel(x + i, y + j).B;
                            }
                    resultImage.SetPixel(x, y, Color.FromArgb(maxR, maxG, maxB));
                }
            }

            return resultImage;
        }

    }
}
