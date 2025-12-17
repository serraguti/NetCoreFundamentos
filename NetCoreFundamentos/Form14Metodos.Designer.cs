namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleRef = new Button();
            btnObjetoRef = new Button();
            lblRaton = new Label();
            label2 = new Label();
            txtSoloNumeros = new TextBox();
            label3 = new Label();
            txtSoloLetras = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(32, 55);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(164, 35);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(31, 130);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(126, 30);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(50, 163);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(137, 77);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleRef
            // 
            btnDobleRef.Location = new Point(15, 263);
            btnDobleRef.Name = "btnDobleRef";
            btnDobleRef.Size = new Size(194, 65);
            btnDobleRef.TabIndex = 4;
            btnDobleRef.Text = "Doble Referencia";
            btnDobleRef.UseVisualStyleBackColor = true;
            btnDobleRef.Click += btnDobleRef_Click;
            // 
            // btnObjetoRef
            // 
            btnObjetoRef.Location = new Point(55, 341);
            btnObjetoRef.Name = "btnObjetoRef";
            btnObjetoRef.Size = new Size(132, 69);
            btnObjetoRef.TabIndex = 5;
            btnObjetoRef.Text = "Objeto referencia";
            btnObjetoRef.UseVisualStyleBackColor = true;
            btnObjetoRef.Click += btnObjetoRef_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.FromArgb(128, 255, 128);
            lblRaton.Location = new Point(235, 163);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(445, 247);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 19);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 7;
            label2.Text = "Sólo números";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(398, 13);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(194, 35);
            txtSoloNumeros.TabIndex = 8;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 80);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 9;
            label3.Text = "Sólo letras";
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(401, 78);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(191, 35);
            txtSoloLetras.TabIndex = 10;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 432);
            Controls.Add(txtSoloLetras);
            Controls.Add(label3);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label2);
            Controls.Add(lblRaton);
            Controls.Add(btnObjetoRef);
            Controls.Add(btnDobleRef);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleRef;
        private Button btnObjetoRef;
        private Label lblRaton;
        private Label label2;
        private TextBox txtSoloNumeros;
        private Label label3;
        private TextBox txtSoloLetras;
    }
}