namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkFormato = new CheckBox();
            label2 = new Label();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            label3 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(31, 49);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(519, 35);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(33, 107);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(189, 34);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 183);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(33, 152);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(71, 34);
            rdbDias.TabIndex = 4;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(31, 192);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(90, 34);
            rdbMeses.TabIndex = 5;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(31, 232);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(78, 34);
            rdbAnyos.TabIndex = 6;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(330, 178);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 35);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(207, 224);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(223, 42);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 292);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 9;
            label3.Text = "Fecha final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(35, 330);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(515, 35);
            txtFechaFinal.TabIndex = 10;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 429);
            Controls.Add(txtFechaFinal);
            Controls.Add(label3);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(rdbAnyos);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(label2);
            Controls.Add(chkFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private Label label2;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label label3;
        private TextBox txtFechaFinal;
    }
}