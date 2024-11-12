using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Ejercicio2 : Form
    {
        private readonly IPhotoRepository<Bitmap> _photoRepository;
        public Ejercicio2(IPhotoRepository<Bitmap> photoRepository)
        {
            InitializeComponent();
            _photoRepository = photoRepository; ;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            var abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.bmp, *.jfif)|*.jpg;*.jpeg;*.png;*.bmp;*.jfif";

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                var filePath = abrirImagen.FileName;
                try
                {
                    Bitmap originalImage = await _photoRepository.LoadAsync(filePath);
                    ptbColor.Image = ResizeImage(originalImage, 307, 317);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al insertar la imagen {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Image ResizeImage(Image image, int v1, int v2)
        {

                Bitmap resizedImage = new Bitmap(v1, v2);
                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.DrawImage(image, 0, 0, v1, v2);
                }
                return resizedImage;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (ptbColor.Image != null)
            {
                try
                {
                    var imagenColor = (Bitmap)ptbColor.Image;

                    Task.Run(() =>
                    {
                            var clonarImagen = (Bitmap)imagenColor.Clone();
                            var proceso = ProcesarImagenParalelo(clonarImagen);
                            ptbModificada.Invoke(new Action(() =>
                            {
                                ptbModificada.Image = (Image)proceso;
                            }));     
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al clonar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor carga una imagen primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Bitmap ProcesarImagenParalelo(Bitmap imagenColor)
        {
            int amo = imagenColor.Width;
            int ame = imagenColor.Height;

            Bitmap proceso = new Bitmap(amo, ame);

            try
            {

                for (int y = 0; y < ame; y++)
                {
                    for (int x = 0; x < amo; x++)
                    {
                        Color pixelColor = imagenColor.GetPixel(x, y);
                        int ye = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                        Color newColor = Color.FromArgb(ye, ye, ye);
                        proceso.SetPixel(x, y, newColor);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error al procesar la imagen: {ex.Message}");
            }

            return proceso;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ptbModificada.Image != null)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = guardar.FileName;

                      
                        Image guardarImagen = (Image)ptbModificada.Image.Clone();

                        guardarImagen.Save(filePath);
                        MessageBox.Show("Imagen guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay una imagen para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void ptbModificada_Click(object sender, EventArgs e)
        {
            var abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.bmp, *.jfif)|*.jpg;*.jpeg;*.png;*.bmp;*.jfif";

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                var filePath = abrirImagen.FileName;
                try
                {
                    ptbColor.Image = await _photoRepository.LoadAsync(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ptbColor_Click(object sender, EventArgs e)
        {
            if (ptbColor.Image != null)
            {
                try
                {
                    var imagenColor = (Bitmap)ptbColor.Image;
                    ptbModificada.Image = await _photoRepository.ProcessAsync(imagenColor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor insertan una imagen de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void Ejercicio2_Load(object sender, EventArgs e)
        {
            try
            {
                var soporte = await _photoRepository.GetSupportedFormatsAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
