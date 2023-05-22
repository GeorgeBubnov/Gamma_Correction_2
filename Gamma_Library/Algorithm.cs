using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Gamma_Library
{
    public class Algorithm : ImageHandler
    {
        public string HandlerName { get => "Гамма-коррекция"; }
        public Bitmap Source { set; get; }
        public Bitmap Result { set; get; }
        public float gamma { set; get; } // Коффициент гамма-коррекции
        public void init(SortedList<string, object> parameters)
        {
            Source = (Bitmap)parameters["Image"];
            gamma = (float)parameters["Gamma"];
        }
        // Выполняем гамма-коррекцию изображения
        public void startHandle(ProgressDelegate progress)
        {
            // Выполняем прямой доступ к пикселям 
            BitmapData bmpData = Source.LockBits(new Rectangle(0, 0, Source.Width, Source.Height),
                ImageLockMode.ReadOnly, Source.PixelFormat);
            byte[] array = new byte[bmpData.Stride * bmpData.Height];
            Marshal.Copy(bmpData.Scan0, array, 0, array.Length);
            Source.UnlockBits(bmpData);

            // Выполняем алгоритм задачи по варианту
            int index;
            for (int i = 0; i < Source.Height; i++)
            {
                for (int j = 0; j < Source.Width; j++)
                {
                    index = bmpData.Stride * i + 3 * j;
                    // Выполняем функцию гамма-коррекции f = c * x^y
                    array[index + 0] = (byte)(255 * Math.Pow(((int)array[index + 0] / 255.0), gamma));
                    array[index + 1] = (byte)(255 * Math.Pow(((int)array[index + 1] / 255.0), gamma));
                    array[index + 2] = (byte)(255 * Math.Pow(((int)array[index + 2] / 255.0), gamma));
                    if (array[index + 0] > 255) // blue
                        array[index + 0] = 255;
                    if (array[index + 1] > 255) // green
                        array[index + 1] = 255;
                    if (array[index + 2] > 255) // red
                        array[index + 2] = 255;
                }
                progress?.Invoke(1);
            }

            Result = new Bitmap(Source.Width, Source.Height, bmpData.Stride, 
                Source.PixelFormat, Marshal.UnsafeAddrOfPinnedArrayElement(array, 0));
        }
    }
}
