namespace NetCoreFundamentos
{
    partial class Form06Email
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
            txtEmail = new TextBox();
            btnComprobarEmail = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduzca email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 66);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(368, 35);
            txtEmail.TabIndex = 1;
            // 
            // btnComprobarEmail
            // 
            btnComprobarEmail.Location = new Point(111, 125);
            btnComprobarEmail.Name = "btnComprobarEmail";
            btnComprobarEmail.Size = new Size(154, 43);
            btnComprobarEmail.TabIndex = 2;
            btnComprobarEmail.Text = "Comprobar";
            btnComprobarEmail.UseVisualStyleBackColor = true;
            btnComprobarEmail.Click += btnComprobarEmail_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(26, 197);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(68, 30);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label2";
            // 
            // Form06Email
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 258);
            Controls.Add(lblResultado);
            Controls.Add(btnComprobarEmail);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form06Email";
            Text = "Form06Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnComprobarEmail;
        private Label lblResultado;
    }
}