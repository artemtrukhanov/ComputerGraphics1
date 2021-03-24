using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class MathMorfology : Filters
    {
        protected int[,] mask = null;

        protected MathMorfology() { }

        public MathMorfology(int[,] mask)
        {
            this.mask = mask;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y) 
        { 
            return Color.FromArgb(0, 0, 0); 
        }
    }
}
