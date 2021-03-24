using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class Grad : MathMorfology
    {
        Dilation dilation;
        Erosion erosion;

        public Grad(int[,] mask)
        {
            dilation = new Dilation(mask);
            erosion = new Erosion(mask);
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height), tempImage1, tempImage2;
            tempImage1 = dilation.processImage(sourceImage, worker);
            tempImage2 = erosion.processImage(sourceImage, worker);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 50) + 50);
                if (worker.CancellationPending)
                    return null;

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int _R = Clamp(tempImage1.GetPixel(i, j).R - tempImage2.GetPixel(i, j).R, 0, 255);
                    int _G = Clamp(tempImage1.GetPixel(i, j).G - tempImage2.GetPixel(i, j).G, 0, 255);
                    int _B = Clamp(tempImage1.GetPixel(i, j).B - tempImage2.GetPixel(i, j).B, 0, 255);

                    resultImage.SetPixel(i, j, Color.FromArgb(_R, _G, _B));
                }
            }

            return resultImage;
        }
    }
}
