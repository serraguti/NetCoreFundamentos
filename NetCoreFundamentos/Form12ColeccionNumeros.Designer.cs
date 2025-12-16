namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerarNumeros = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            label3 = new Label();
            txtImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Items.AddRange(new object[] { "5", "2", "7", "3", "8", "4" });
            lstNumeros.Location = new Point(21, 54);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(206, 244);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerarNumeros
            // 
            btnGenerarNumeros.Location = new Point(266, 20);
            btnGenerarNumeros.Name = "btnGenerarNumeros";
            btnGenerarNumeros.Size = new Size(191, 52);
            btnGenerarNumeros.TabIndex = 2;
            btnGenerarNumeros.Text = "Generar números";
            btnGenerarNumeros.UseVisualStyleBackColor = true;
            btnGenerarNumeros.Click += btnGenerarNumeros_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(266, 89);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(191, 48);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 172);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 4;
            label2.Text = "Suma:";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(357, 167);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 35);
            txtSuma.TabIndex = 5;
            txtSuma.Text = "29";
            // 
            // txtPares
            // 
            txtPares.Location = new Point(357, 218);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 35);
            txtPares.TabIndex = 7;
            txtPares.Text = "14";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 223);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 6;
            label3.Text = "Pares:";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(357, 263);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 35);
            txtImpares.TabIndex = 9;
            txtImpares.Text = "15";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 268);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 8;
            label4.Text = "Impares: ";
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 326);
            Controls.Add(txtImpares);
            Controls.Add(label4);
            Controls.Add(txtPares);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerarNumeros);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerarNumeros;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtSuma;
        private TextBox txtPares;
        private Label label3;
        private TextBox txtImpares;
        private Label label4;
    }
}