using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Pelykh
{
    public class Histogram
    {
        public long[] histogram = new long[256];


        public void GetHistogram(Bitmap resultBmp)
        {
            //Массив значений Histogram'а размером 256
            //Создание объекта bmData класса BitmapData принимающего значение null
            BitmapData bmData = null;

            try
            {
                //Лок битов 32bpp
                bmData = resultBmp.LockBits(new Rectangle(0, 0, resultBmp.Width, resultBmp.Height), ImageLockMode.ReadOnly, resultBmp.PixelFormat);
                //Байты в пикселе
                int bytesPerPixel = Bitmap.GetPixelFormatSize(resultBmp.PixelFormat) / 8;
                int heightInPixels = resultBmp.Height;
                int widthInPixels = resultBmp.Width * bytesPerPixel;
                System.IntPtr Scan0 = bmData.Scan0;
                unsafe
                {
                    byte* ptrFirstPixel = (byte*)(void*)Scan0;
                    for (int y = 0; y < heightInPixels; y++)
                    {
                        byte* currentLine = ptrFirstPixel + (y * bmData.Stride);
                        for (int x = 0; x < widthInPixels; x += bytesPerPixel)
                        {
                            histogram[currentLine[x]]++;
                        }
                    }
                }
                resultBmp.UnlockBits(bmData);
            }
            catch
            {
                try
                {
                    resultBmp.UnlockBits(bmData);
                }
                catch
                {
                }
            }

        }
    }
}
