using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Project_Pelykh
{
    public class BitmapFilter
    {
        //Simple Grayscale
        public static Bitmap GrayScale(Bitmap sourceBmp)
        {
            //create a blank bitmap the same size as original
            Bitmap resultBmp = new Bitmap(sourceBmp.Width, sourceBmp.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(resultBmp);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(sourceBmp, new Rectangle(0, 0, sourceBmp.Width, sourceBmp.Height), // destination rectangle 
                        0, 0, // upper-left corner of source rectangle 
                        sourceBmp.Width, // width of source rectangle
                        sourceBmp.Height, // height of source rectangle
                        GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return resultBmp;
        }

        //Custom Grayscale
        public static Bitmap GetGrayscale(Bitmap sourceBmp, float kR, float kG, float kB)
        {
            //create a blank bitmap the same size as original
            Bitmap resultBmp = new Bitmap(sourceBmp.Width, sourceBmp.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(resultBmp);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                 new float[] {.3f * kR, .3f * kR, .3f * kR, 0, 0}, // red scaling factor
                 new float[] {.59f * kG, .59f * kG, .59f * kG, 0, 0}, // green scaling factor
                 new float[] { .11f * kB, .11f * kB, .11f * kB, 0, 0}, // blue scaling factor
                 new float[] {0, 0, 0, 1, 0}, // alpha scaling factor
                 new float[] {0, 0, 0, 0, 1} // three translations
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(sourceBmp, new Rectangle(0, 0, sourceBmp.Width, sourceBmp.Height), // destination rectangle 
                        0, 0, // upper-left corner of source rectangle 
                        sourceBmp.Width, // width of source rectangle
                        sourceBmp.Height, // height of source rectangle
                        GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return resultBmp;
        }

        //Negative
        public static Bitmap Invert(Bitmap sourceBmp)
        {
                //create a blank bitmap the same size as original
                Bitmap resultBmp = new Bitmap(sourceBmp.Width, sourceBmp.Height);

                //get a graphics object from the new image
                Graphics g = Graphics.FromImage(resultBmp);

                // create the negative color matrix
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {-1, 0, 0, 0, 0},
                    new float[] {0, -1, 0, 0, 0},
                    new float[] {0, 0, -1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {1, 1, 1, 0, 1}
                });

                // create some image attributes
                ImageAttributes attributes = new ImageAttributes();

                attributes.SetColorMatrix(colorMatrix);

                g.DrawImage(sourceBmp, new Rectangle(0, 0, sourceBmp.Width, sourceBmp.Height), // destination rectangle 
                            0, 0, // upper-left corner of source rectangle 
                            sourceBmp.Width, // width of source rectangle
                            sourceBmp.Height, // height of source rectangle
                            GraphicsUnit.Pixel, attributes);

                //dispose the Graphics object
                g.Dispose();
            return resultBmp;
            }


        public static Bitmap Resize(Bitmap b, int nWidth, int nHeight, bool bBilinear)
        {
            Bitmap bTemp = (Bitmap)b.Clone();
            b = new Bitmap(nWidth, nHeight, bTemp.PixelFormat);

            double nXFactor = (double)bTemp.Width / (double)nWidth;
            double nYFactor = (double)bTemp.Height / (double)nHeight;

            //Bilinear filter
            if (bBilinear)
            {
                double fraction_x, fraction_y, one_minus_x, one_minus_y;
                int ceil_x, ceil_y, floor_x, floor_y;
                Color c1 = new Color();
                Color c2 = new Color();
                Color c3 = new Color();
                Color c4 = new Color();
                byte red, green, blue;

                byte b1, b2;

                for (int x = 0; x < b.Width; ++x)
                    for (int y = 0; y < b.Height; ++y)
                    {
                        // Setup

                        floor_x = (int)Math.Floor(x * nXFactor);
                        floor_y = (int)Math.Floor(y * nYFactor);
                        ceil_x = floor_x + 1;
                        if (ceil_x >= bTemp.Width) ceil_x = floor_x;
                        ceil_y = floor_y + 1;
                        if (ceil_y >= bTemp.Height) ceil_y = floor_y;
                        fraction_x = x * nXFactor - floor_x;
                        fraction_y = y * nYFactor - floor_y;
                        one_minus_x = 1.0 - fraction_x;
                        one_minus_y = 1.0 - fraction_y;

                        c1 = bTemp.GetPixel(floor_x, floor_y);
                        c2 = bTemp.GetPixel(ceil_x, floor_y);
                        c3 = bTemp.GetPixel(floor_x, ceil_y);
                        c4 = bTemp.GetPixel(ceil_x, ceil_y);

                        // Blue
                        b1 = (byte)(one_minus_x * c1.B + fraction_x * c2.B);

                        b2 = (byte)(one_minus_x * c3.B + fraction_x * c4.B);

                        blue = (byte)(one_minus_y * (double)(b1) + fraction_y * (double)(b2));

                        // Green
                        b1 = (byte)(one_minus_x * c1.G + fraction_x * c2.G);

                        b2 = (byte)(one_minus_x * c3.G + fraction_x * c4.G);

                        green = (byte)(one_minus_y * (double)(b1) + fraction_y * (double)(b2));

                        // Red
                        b1 = (byte)(one_minus_x * c1.R + fraction_x * c2.R);

                        b2 = (byte)(one_minus_x * c3.R + fraction_x * c4.R);

                        red = (byte)(one_minus_y * (double)(b1) + fraction_y * (double)(b2));

                        b.SetPixel(x, y, System.Drawing.Color.FromArgb(255, red, green, blue));
                    }
            }
            else
            {
                for (int x = 0; x < b.Width; ++x)
                    for (int y = 0; y < b.Height; ++y)
                        b.SetPixel(x, y, bTemp.GetPixel((int)(Math.Floor(x * nXFactor)), (int)(Math.Floor(y * nYFactor))));
            }

            return b;
        }

        //Flip image
        public static Bitmap OffsetFilterAbs(Bitmap b, Point[,] offset)
        {
            Bitmap bSrc = (Bitmap)b.Clone();

            // GDI+ still lies to us - the return format is BGR, NOT RGB.
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int scanline = bmData.Stride;

            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr SrcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* pSrc = (byte*)(void*)SrcScan0;

                int nOffset = bmData.Stride - b.Width * 3;
                int nWidth = b.Width;
                int nHeight = b.Height;

                int xOffset, yOffset;

                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        xOffset = offset[x, y].X;
                        yOffset = offset[x, y].Y;

                        if (yOffset >= 0 && yOffset < nHeight && xOffset >= 0 && xOffset < nWidth)
                        {
                            p[0] = pSrc[(yOffset * scanline) + (xOffset * 3)];
                            p[1] = pSrc[(yOffset * scanline) + (xOffset * 3) + 1];
                            p[2] = pSrc[(yOffset * scanline) + (xOffset * 3) + 2];
                        }

                        p += 3;
                    }
                    p += nOffset;
                }
            }

            b.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);

            return bSrc;
        }

        //Flip image
        public static Bitmap Flip(Bitmap b, bool bHorz, bool bVert)
        {
            Bitmap resultBmp = new Bitmap(b.Width, b.Height);
            Point[,] ptFlip = new Point[b.Width, b.Height];

            int nWidth = b.Width;
            int nHeight = b.Height;

            for (int x = 0; x < nWidth; ++x)
                for (int y = 0; y < nHeight; ++y)
                {
                    ptFlip[x, y].X = (bHorz) ? nWidth - (x + 1) : x;
                    ptFlip[x, y].Y = (bVert) ? nHeight - (y + 1) : y;
                }

            resultBmp = OffsetFilterAbs(b, ptFlip);

            return resultBmp;
        }

        //Binarization
        public static Bitmap Threshold(Image image, float threshold)
        {
            // Make the result bitmap.
            Bitmap bm = new Bitmap(image.Width, image.Height);

            // Make the ImageAttributes object and set the threshold.
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetThreshold(threshold);

            // Draw the image onto the new bitmap
            // while applying the new ColorMatrix.
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect =
                new Rectangle(0, 0, image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect,
                    GraphicsUnit.Pixel, attributes);
            }

            // Return the result.
            return bm;
        }

        //Contrast
        public static Bitmap Contrast(Bitmap sourceBmp, float tbContrast)
        {
            float contrast = 0.04f * tbContrast;

            Bitmap resultBmp = new Bitmap(sourceBmp.Width, sourceBmp.Height);

            Graphics g = Graphics.FromImage(resultBmp);
            ImageAttributes attributes = new ImageAttributes();

            ColorMatrix colorMatrix = new ColorMatrix(new float[][]{
                 new float[] {contrast, 0f, 0f, 0f, 0f}, // red scaling factor
                 new float[] {0f, contrast, 0f, 0f, 0f}, // green scaling factor
                 new float[] {0f, 0f, contrast, 0f, 0f}, // blue scaling factor
                 new float[] {0f, 0f, 0f, 1f, 0f}, // alpha scaling factor
                 new float[] {0.001f, 0.001f, 0.001f, 0f, 1f}});

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(sourceBmp, new Rectangle(0, 0, sourceBmp.Width, sourceBmp.Height), // destination rectangle 
            0, 0, // upper-left corner of source rectangle 
            sourceBmp.Width, // width of source rectangle
            sourceBmp.Height, // height of source rectangle
            GraphicsUnit.Pixel, attributes);
            g.Dispose();

            return resultBmp;
        }

        //Brightness
        public static Bitmap Brightness(Bitmap sourceBmp, int tbBright)
        {


            Bitmap resultBmp = new Bitmap(sourceBmp.Width, sourceBmp.Height);

            Graphics g = Graphics.FromImage(resultBmp);

            float FinalValue = tbBright / 255.0f;

            float[][] FloatColorMatrix ={

                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                };

            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);

            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(NewColorMatrix);

            g.DrawImage(sourceBmp, new Rectangle(0, 0, sourceBmp.Width, sourceBmp.Height), // destination rectangle 
            0, 0, // upper-left corner of source rectangle 
            sourceBmp.Width, // width of source rectangle
            sourceBmp.Height, // height of source rectangle
            GraphicsUnit.Pixel, attributes);
            g.Dispose();

            return resultBmp;
        }

        public static Bitmap ClrToClr(Bitmap sourceBmp, Color color)
        {
            Bitmap resultBmp = new Bitmap(sourceBmp.Width, sourceBmp.Height);

            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;


            // Color Matrix
            ColorMatrix cm = new ColorMatrix(new float[][]
            {
                new float[] {r, 0, 0, 0, 0},
                new float[] {0, g, 0, 0, 0},
                new float[] {0, 0, b, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
            ImageAttributes ImAttribute = new ImageAttributes();
            ImAttribute.SetColorMatrix(cm);

            //Color Matrix on new bitmap image
            Point[] points =
            {
                new Point(0, 0),
                new Point(sourceBmp.Width - 1, 0),
                new Point(0, sourceBmp.Height - 1),
            };
            Rectangle rect = new Rectangle(0, 0, sourceBmp.Width, sourceBmp.Height);

            using (Graphics graphics = Graphics.FromImage(resultBmp))
            {
                graphics.DrawImage(sourceBmp, points, rect, GraphicsUnit.Pixel, ImAttribute);
            }
            return resultBmp;
        }
    }
}