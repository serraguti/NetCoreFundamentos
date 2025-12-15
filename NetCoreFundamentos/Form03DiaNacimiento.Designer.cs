namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            label2 = new Label();
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            btnMostrarDia = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 30);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 65);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 111);
            label3.Name = "label3";
            label3.Size = new Size(51, 30);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(112, 12);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 35);
            txtDia.TabIndex = 3;
            txtDia.Text = "15";
            // 
            // txtMes
            // 
            txtMes.Location = new Point(112, 59);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 35);
            txtMes.TabIndex = 4;
            txtMes.Text = "12";
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(112, 105);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 35);
            txtAnyo.TabIndex = 5;
            txtAnyo.Text = "2025";
            // 
            // btnMostrarDia
            // 
            btnMostrarDia.Location = new Point(27, 167);
            btnMostrarDia.Name = "btnMostrarDia";
            btnMostrarDia.Size = new Size(216, 52);
            btnMostrarDia.TabIndex = 6;
            btnMostrarDia.Text = "Mostrar día";
            btnMostrarDia.UseVisualStyleBackColor = true;
            btnMostrarDia.Click += btnMostrarDia_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = Color.Blue;
            lblResultado.Location = new Point(37, 240);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(286, 30);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "El día de la semana es LUNES";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 299);
            Controls.Add(lblResultado);
            Controls.Add(btnMostrarDia);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
        private Button btnMostrarDia;
        private Label lblResultado;
    }
}