using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class Erosion : MathMorfology
    {
        public Erosion(int[,] mask)
        {
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            int mh = mask.GetUpperBound(0) + 1;
            int mw = mask.Length / mh;

            for (int y = mh / 2; y < sourceImage.Height - mh / 2; y++)
            {
                worker.ReportProgress((int)((float)y / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;

                for (int x = mw / 2; x < sourceImage.Width - mw / 2; x++)
                {
                    int minR = 255;
                    int minG = 255;
                    int minB = 255;
                    for (int j = -mh / 2; j <= mh / 2; j++)
                        for (int i = -mw / 2; i <= mw / 2; i++)
                            if (mask[mw / 2 + i, mh / 2 + j] == 1)
                            {
                                if (sourceImage.GetPixel(x + i, y + j).R < minR)
                                    minR = sourceImage.GetPixel(x + i, y + j).R;
                                if (sourceImage.GetPixel(x + i, y + j).G < minG)
                                    minG = sourceImage.GetPixel(x + i, y + j).G;
                                if (sourceImage.GetPixel(x + i, y + j).B < minB)
                                    minB = sourceImage.GetPixel(x + i, y + j).B;
                            }
                    resultImage.SetPixel(x, y, Color.FromArgb(minR, minG, minB));
                }
            }

            return resultImage;
        }
    }
}
