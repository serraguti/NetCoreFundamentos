namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
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
            lstTienda = new ListBox();
            label2 = new Label();
            txtProducto = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnClear = new Button();
            btnSeleccion = new Button();
            btnTodos = new Button();
            lstAlmacen = new ListBox();
            label3 = new Label();
            btnDown = new Button();
            btnUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 21);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 0;
            label1.Text = "Tienda";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(188, 62);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(178, 214);
            lstTienda.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 29);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 2;
            label2.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(17, 62);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(154, 35);
            txtProducto.TabIndex = 3;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(18, 110);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(153, 46);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(18, 162);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 46);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(17, 214);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(153, 46);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(372, 97);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(153, 46);
            btnSeleccion.TabIndex = 7;
            btnSeleccion.Text = "Selección";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(372, 162);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(153, 46);
            btnTodos.TabIndex = 8;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(531, 62);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(178, 214);
            lstAlmacen.TabIndex = 10;
            lstAlmacen.SelectedIndexChanged += lstAlmacen_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 21);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 9;
            label3.Text = "Almacén";
            // 
            // btnDown
            // 
            btnDown.Location = new Point(718, 175);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(100, 46);
            btnDown.TabIndex = 12;
            btnDown.Text = "Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(718, 110);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(100, 46);
            btnUp.TabIndex = 11;
            btnUp.Text = "Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 358);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(lstAlmacen);
            Controls.Add(label3);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(btnClear);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(lstTienda);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstTienda;
        private Label label2;
        private TextBox txtProducto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnClear;
        private Button btnSeleccion;
        private Button btnTodos;
        private ListBox lstAlmacen;
        private Label label3;
        private Button btnDown;
        private Button btnUp;
    }
}