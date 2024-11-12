namespace Ejercicio_2
{
    partial class Ejercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ptbModificada = new PictureBox();
            ptbColor = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btnSalir = new Button();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbModificada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbColor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 64);
            label1.Name = "label1";
            label1.Size = new Size(516, 41);
            label1.TabIndex = 0;
            label1.Text = "Modificar los pixeles a escala grises";
            label1.Click += label1_Click;
            // 
            // ptbModificada
            // 
            ptbModificada.Location = new Point(599, 161);
            ptbModificada.Name = "ptbModificada";
            ptbModificada.Size = new Size(307, 317);
            ptbModificada.TabIndex = 1;
            ptbModificada.TabStop = false;
            ptbModificada.Click += ptbModificada_Click;
            // 
            // ptbColor
            // 
            ptbColor.Location = new Point(80, 161);
            ptbColor.Name = "ptbColor";
            ptbColor.Size = new Size(307, 317);
            ptbColor.TabIndex = 2;
            ptbColor.TabStop = false;
            ptbColor.Click += ptbColor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Moccasin;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(151, 118);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 3;
            label2.Text = "Imagen a color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(630, 118);
            label3.Name = "label3";
            label3.Size = new Size(212, 31);
            label3.TabIndex = 4;
            label3.Text = "Imagen modificada";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(805, 650);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 53);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Transparent;
            btnInsertar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertar.Location = new Point(97, 530);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(263, 53);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar Imagen";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Transparent;
            btnModificar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(403, 530);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(180, 53);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(630, 530);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(254, 53);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Imagen";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Ejercicio2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(997, 715);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(btnSalir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ptbColor);
            Controls.Add(ptbModificada);
            Controls.Add(label1);
            Name = "Ejercicio2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio2";
            Load += Ejercicio2_Load;
            ((System.ComponentModel.ISupportInitialize)ptbModificada).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox ptbModificada;
        private PictureBox ptbColor;
        private Label label2;
        private Label label3;
        private Button btnSalir;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnGuardar;
    }
}