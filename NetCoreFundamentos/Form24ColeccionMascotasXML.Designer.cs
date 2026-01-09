namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
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
            txtEdad = new TextBox();
            label3 = new Label();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnLeerMascotas = new Button();
            btnGuardarMascotas = new Button();
            btnNuevaMascota = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(40, 227);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 35);
            txtEdad.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 192);
            label3.Name = "label3";
            label3.Size = new Size(59, 30);
            label3.TabIndex = 10;
            label3.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(39, 138);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(229, 35);
            txtRaza.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 104);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 8;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 35);
            txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 15);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 12;
            label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(304, 46);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(250, 274);
            lstMascotas.TabIndex = 13;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(599, 41);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(170, 54);
            btnLeerMascotas.TabIndex = 14;
            btnLeerMascotas.Text = "Leer Mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(600, 114);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(169, 84);
            btnGuardarMascotas.TabIndex = 15;
            btnGuardarMascotas.Text = "Guardar mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(39, 278);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(229, 42);
            btnNuevaMascota.TabIndex = 16;
            btnNuevaMascota.Text = "Nueva mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(787, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(604, 233);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(165, 63);
            btnExaminar.TabIndex = 18;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 360);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevaMascota);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEdad;
        private Label label3;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnLeerMascotas;
        private Button btnGuardarMascotas;
        private Button btnNuevaMascota;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}