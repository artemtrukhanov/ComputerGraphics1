using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab1
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
            }

            pictureBox1.Image = image;
            pictureBox1.Refresh();
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }


        private void горизонтальнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new HorizontalWaveFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void эффектСтеклаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter(5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void расширениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[,] mask = null;
            mask = new int[,] { { 1, 0, 1 }, { 0, 0, 0 }, { 1, 0, 1 } };
            Filters filter = new Dilation(mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сужениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[,] mask = null;
            mask = new int[,] { { 0, 0, 1, 1, 1, 0, 0 }, { 0, 1, 1, 1, 1, 1, 0 }, { 1, 1, 1, 1, 1, 1, 1 },
             { 1, 1, 1, 1, 1, 1, 1 },  { 1, 1, 1, 1, 1, 1, 1 }, { 0, 1, 1, 1, 1, 1, 0 }, { 0, 0, 1, 1, 1, 0, 0 }};
            Filters filter = new Erosion(mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void закрытиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[,] mask = null;
            mask = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Filters filter = new Closing(mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void открытиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[,] mask = null;
            mask = new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
            Filters filter = new Opening(mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] mask = null;
            mask = new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
            Filters filter = new Grad(mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void чернобелыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void серыйМирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayWorld();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void интенсивностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new IntensityFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sepia();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void растяжениеГистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new StretchFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sharpen();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void гауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new PrewittXFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new PrewittYFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void pXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelXFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void pYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelYFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
