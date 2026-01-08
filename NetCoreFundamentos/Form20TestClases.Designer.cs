namespace NetCoreFundamentos
{
    partial class Form20TestClases
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
            lstClases = new ListBox();
            btnCrearPersona = new Button();
            btnEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(26, 69);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(669, 274);
            lstClases.TabIndex = 1;
            // 
            // btnCrearPersona
            // 
            btnCrearPersona.Location = new Point(26, 372);
            btnCrearPersona.Name = "btnCrearPersona";
            btnCrearPersona.Size = new Size(163, 50);
            btnCrearPersona.TabIndex = 2;
            btnCrearPersona.Text = "Crear Persona";
            btnCrearPersona.UseVisualStyleBackColor = true;
            btnCrearPersona.Click += btnCrearPersona_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(212, 372);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(201, 50);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 478);
            Controls.Add(btnEmpleado);
            Controls.Add(btnCrearPersona);
            Controls.Add(lstClases);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstClases;
        private Button btnCrearPersona;
        private Button btnEmpleado;
    }
}