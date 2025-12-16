namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            lblTiempo = new Label();
            btnInvertirString = new Button();
            btnInvertirStringBuilder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(248, 30);
            label1.TabIndex = 0;
            label1.Text = "Copie texto para trabajar:";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(39, 63);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(699, 317);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.ForeColor = Color.Red;
            lblTiempo.Location = new Point(37, 392);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(104, 30);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "lblTiempo";
            // 
            // btnInvertirString
            // 
            btnInvertirString.Location = new Point(103, 447);
            btnInvertirString.Name = "btnInvertirString";
            btnInvertirString.Size = new Size(239, 54);
            btnInvertirString.TabIndex = 3;
            btnInvertirString.Text = "Invertir String";
            btnInvertirString.UseVisualStyleBackColor = true;
            btnInvertirString.Click += btnInvertirString_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(442, 447);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(248, 54);
            btnInvertirStringBuilder.TabIndex = 4;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 513);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertirString);
            Controls.Add(lblTiempo);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Label lblTiempo;
        private Button btnInvertirString;
        private Button btnInvertirStringBuilder;
    }
}