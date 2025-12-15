namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            txtPosicionX = new TextBox();
            label2 = new Label();
            txtPosicionY = new TextBox();
            btnCambiarPosicion = new Button();
            label3 = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            label4 = new Label();
            txtAzul = new TextBox();
            label5 = new Label();
            btnCambiarFondo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 0;
            label1.Text = "Posición X";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(33, 49);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 35);
            txtPosicionX.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 97);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 2;
            label2.Text = "Posición Y";
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(37, 133);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 35);
            txtPosicionY.TabIndex = 3;
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(28, 192);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(127, 76);
            btnCambiarPosicion.TabIndex = 4;
            btnCambiarPosicion.Text = "Cambiar posición";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 22);
            label3.Name = "label3";
            label3.Size = new Size(54, 30);
            label3.TabIndex = 5;
            label3.Text = "Rojo";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(346, 17);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 35);
            txtRojo.TabIndex = 6;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(346, 71);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 35);
            txtVerde.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 76);
            label4.Name = "label4";
            label4.Size = new Size(66, 30);
            label4.TabIndex = 7;
            label4.Text = "Verde";
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(346, 122);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 35);
            txtAzul.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 127);
            label5.Name = "label5";
            label5.Size = new Size(54, 30);
            label5.TabIndex = 9;
            label5.Text = "Azul";
            // 
            // btnCambiarFondo
            // 
            btnCambiarFondo.Location = new Point(281, 192);
            btnCambiarFondo.Name = "btnCambiarFondo";
            btnCambiarFondo.Size = new Size(165, 58);
            btnCambiarFondo.TabIndex = 11;
            btnCambiarFondo.Text = "Cambiar fondo";
            btnCambiarFondo.UseVisualStyleBackColor = true;
            btnCambiarFondo.Click += btnCambiarFondo_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 297);
            Controls.Add(btnCambiarFondo);
            Controls.Add(txtAzul);
            Controls.Add(label5);
            Controls.Add(txtVerde);
            Controls.Add(label4);
            Controls.Add(txtRojo);
            Controls.Add(label3);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(txtPosicionY);
            Controls.Add(label2);
            Controls.Add(txtPosicionX);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPosicionX;
        private Label label2;
        private TextBox txtPosicionY;
        private Button btnCambiarPosicion;
        private Label label3;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private Label label4;
        private TextBox txtAzul;
        private Label label5;
        private Button btnCambiarFondo;
    }
}