using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
  public class Photo
    {
        public Bitmap ProcessImage(Bitmap originalImage)
        {
            int width = originalImage.Width;
            int height = originalImage.Height;
            Bitmap processedImage = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int grayScale = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    processedImage.SetPixel(x, y, newColor);
                }
            }

            return processedImage;
        }
    }
}