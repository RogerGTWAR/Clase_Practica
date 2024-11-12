namespace Ejercicio_1
{
    public partial class Ejercicio1 : Form
    {
        private readonly IFileRepository _fileRepository;

        public Ejercicio1()
        {
     
            InitializeComponent();
            _fileRepository = new TextFileRepository();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMinusculas_TextChanged(object sender, EventArgs e)
        {

        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivos de texto (*.txt)|*.txt";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                string contenido = txtMinusculas.Text;
                string filePath = guardarArchivo.FileName;

                try
                {
                    await SaveFileAsync(filePath, contenido);
                    MessageBox.Show("Guardado completado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar: {ex.Message}");
                }
            }
        }

        private async Task SaveFileAsync(string filePath, string contenido)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                await writer.WriteAsync(contenido);
            }
        }
        private async void bntModificador_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "Archivos de texto (*.txt)|*.txt";
            abrirArchivo.Multiselect = false;

            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                string filePath = abrirArchivo.FileName;
                await ProcessFileAsync(filePath);

            }
        }
        private async Task ProcessFileAsync(string filePath)
        {
            try
            {
                string contenido = await _fileRepository.ReadFileAsync(filePath);
                string proceso = ProcessText(contenido);
                await _fileRepository.SaveFileAsync(filePath, proceso);
                MessageBox.Show("Proceso de archivo completado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar {Path.GetFileName(filePath)}: {ex.Message}");
            }
        }

        private string ProcessText(string content)
        {
            return content.ToUpper();
        }


        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

    }
}

