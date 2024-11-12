using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class PhotoRepository : IPhotoRepository<Bitmap>
    {
        public async Task<List<string>> GetSupportedFormatsAsync()
        {
            return await Task.FromResult(new List<string> { ".jpg", ".jpeg", ".png", ".bmp", ".jfif" });
        }

        public async Task<Bitmap> LoadAsync(string filePath)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (File.Exists(filePath))
                    {
                        return (Bitmap)Image.FromFile(filePath);
                    }
                    else
                    {
                        throw new FileNotFoundException("El archivo de imagen no existe.");
                    }
                });
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error al cargar la imagen: {ex.Message}");
            }
        }

        public async Task<Bitmap> ProcessAsync(Bitmap originalImage)
        {
            try
            {
                return await Task.Run(() =>
                {
                    int width = originalImage.Width;
                    int height = originalImage.Height;
                    Bitmap processedImage = new Bitmap(width, height);

                    Parallel.For(0, height, y =>
                    {
                        for (int x = 0; x < width; x++)
                        {
                            Color pixelColor = originalImage.GetPixel(x, y);
                            int grayScale = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                            Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                            processedImage.SetPixel(x, y, newColor);
                        }
                    });

                    return processedImage;
                });
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error al procesar la imagen: {ex.Message}");
            }
        }
    }
}
