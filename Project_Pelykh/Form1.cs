using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pelykh
{
    public partial class Form1 : Form
    {
        Histogram resultHistogram;
        Bitmap sourceBitmap;
        Bitmap resultBitmap;

        public Form1()
        {
            InitializeComponent();
            bBilinear = true;
        }

        //Open File
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Jpeg files (*.jpg)|*.jpg|All Files|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sourceBitmap = new Bitmap(openFileDialog.FileName);
                sourcePictureBox.Image = sourceBitmap;
                resultPictureBox.Image = sourceBitmap;

                //Histogram for Source Bitmap
                CreateHistogram(sourceBitmap);
            }
        }

        //Save File
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sourceBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

                sfd.ShowDialog();
                string filename = sfd.FileName;
                resultPictureBox.Image.Save(filename);
            }
        }

        //Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (sourceBitmap != null)
            {
                resultPictureBox.Image = sourceBitmap;

                //Histogram for Clear Bitmap
                CreateHistogram(sourceBitmap);
            }
        }

        //Simple Grayscale
        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            if (sourceBitmap != null)
            {
                resultBitmap = BitmapFilter.GrayScale(sourceBitmap);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Grayscale Bitmap
                CreateHistogram(resultBitmap);
            }
        }

        //Custom Grayscale
        private void ColorToGrayscale_Scroll(object sender, ScrollEventArgs e)
        {
            if (sourceBitmap != null)
            {
                //Color to Grayscale
                //ColorToGrayscle ctg = new ColorToGrayscle(sourceBitmap, tbrR.Value * 0.01, tbrG.Value * 0.01, tbrB.Value * 0.01);
                resultBitmap = BitmapFilter.GetGrayscale(sourceBitmap, tbrR.Value, tbrG.Value, tbrB.Value);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Grayscale Bitmap
                CreateHistogram(resultBitmap);
            }
        }

        //Draw Histogram
        private void DrawHistogram()
        {
            long[] hist = resultHistogram.histogram;
            MainHistogram.Series["Histogram"].Points.DataBindXY(Enumerable.Range(0, 256).ToList(), hist.ToList());
        }

        //Create New Histogram
        private void CreateHistogram(Bitmap bmp)
        {
            //For refreshing Histogram
            resultHistogram = new Histogram();
            resultHistogram.GetHistogram(bmp);
            DrawHistogram();
        }

        //Invert
        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (sourceBitmap != null)
            {
                resultBitmap = BitmapFilter.Invert(sourceBitmap);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Grayscale Bitmap
                CreateHistogram(resultBitmap);
            }
        }

        public bool bBilinear
        {
            get
            {
                return BilinearBox.Checked; ;
            }
            set { BilinearBox.Checked = value; }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (sourceBitmap != null)
            {
                resultBitmap = BitmapFilter.Resize(sourceBitmap, Convert.ToInt32(WidthBox.Text), Convert.ToInt32(HeightBox.Text), bBilinear);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Grayscale Bitmap
                CreateHistogram(resultBitmap);
            }
        }

        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            if (sourceBitmap != null)
            {
                resultBitmap = BitmapFilter.Flip(sourceBitmap, true, false);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Grayscale Bitmap
                //CreateHistogram(resultBitmap);
            }
        }

        private void btnVertical_Click(object sender, EventArgs e)
        {
            if (sourceBitmap != null)
            {
                resultBitmap = BitmapFilter.Flip(sourceBitmap, false, true);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Grayscale Bitmap
                //CreateHistogram(resultBitmap);
            }
        }

        private void btnBoth_Click(object sender, EventArgs e)
        {
            if (sourceBitmap != null)
            {
                resultBitmap = BitmapFilter.Flip(sourceBitmap, true, true);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Grayscale Bitmap
                //CreateHistogram(resultBitmap);
            }
        }

        private void BinScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (sourceBitmap != null)
            {
                labelTh.Text = "Color threshold " + BinScroll.Value;
                resultBitmap = BitmapFilter.Threshold(sourceBitmap, BinScroll.Value);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Binar Bitmap
                CreateHistogram(resultBitmap);
            }
        }

        private void ContrastScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (sourceBitmap != null)
            {
                labelCntrst.Text = "Contrast: " + ContrastScroll.Value;
                resultBitmap = BitmapFilter.Contrast(sourceBitmap, ContrastScroll.Value);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Binar Bitmap
                CreateHistogram(resultBitmap);
            }
        }

        private void BrightnessScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (sourceBitmap != null)
            {
                labelBright.Text = "Brightness: " + BrightnessScroll.Value;
                resultBitmap = BitmapFilter.Brightness(sourceBitmap, BrightnessScroll.Value);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Binar Bitmap
                CreateHistogram(resultBitmap);
            }
        }

        private void ColorToColor_Scroll(object sender, ScrollEventArgs e)
        {
            //Redrawing & adjusting the selected color
            SelectedColor.BackColor = Color.FromArgb(RedSelection.Value, GreenSelection.Value, BlueSelection.Value);
            if (sourceBitmap != null)
            {
                //Applyig color
                resultBitmap = BitmapFilter.ClrToClr(sourceBitmap, SelectedColor.BackColor);
                resultPictureBox.Image = resultBitmap;

                //Histogram for Binar Bitmap
                CreateHistogram(resultBitmap);
            }
        }
    }
}
