using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class Closing : MathMorfology
    {
        Erosion erosion;
        Dilation dilation;

        public Closing(int[,] mask)
        {
            erosion = new Erosion(mask);
            dilation = new Dilation(mask);
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            return erosion.processImage(dilation.processImage(sourceImage, worker), worker);
        }
    }
}
