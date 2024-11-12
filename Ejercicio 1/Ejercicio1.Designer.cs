namespace Ejercicio_1
{
    partial class Ejercicio1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio1));
            btnSalir = new Button();
            txtMinusculas = new TextBox();
            btnModificardor = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(673, 486);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 86);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtMinusculas
            // 
            txtMinusculas.Location = new Point(26, 115);
            txtMinusculas.Multiline = true;
            txtMinusculas.Name = "txtMinusculas";
            txtMinusculas.Size = new Size(977, 281);
            txtMinusculas.TabIndex = 2;
            txtMinusculas.TextChanged += txtMinusculas_TextChanged;
            // 
            // btnModificardor
            // 
            btnModificardor.BackColor = Color.Transparent;
            btnModificardor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificardor.Location = new Point(436, 486);
            btnModificardor.Name = "btnModificardor";
            btnModificardor.Size = new Size(158, 86);
            btnModificardor.TabIndex = 3;
            btnModificardor.Text = "Modificar";
            btnModificardor.UseVisualStyleBackColor = false;
            btnModificardor.Click += bntModificador_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(206, 486);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 86);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 53);
            label1.Name = "label1";
            label1.Size = new Size(581, 41);
            label1.TabIndex = 6;
            label1.Text = "Bienvenido a su modificador de archivo txt";
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1053, 717);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificardor);
            Controls.Add(txtMinusculas);
            Controls.Add(btnSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ejercicio1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio1";
            Load += Ejercicio1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalir;
        private TextBox txtMinusculas;
        private Button btnModificardor;
        private Button btnGuardar;
        private Label label1;
    }
}
