using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        int SumarNumeros(int num1, int num2) {
            int suma = num1 + num2;
            return suma;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int valor = this.SumarNumeros(2, 4);

            string producto = this.txtProducto.Text.ToUpper();
            int index = this.lstTienda.Items.IndexOf(producto);
            if (index == -1)
            {
                this.lstTienda.Items.Add(producto);
                this.txtProducto.Focus();
                this.txtProducto.SelectAll();
            }
            else
            {
                this.lstTienda.SelectedIndex = index;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numProductos = this.lstTienda.SelectedItems.Count;
            for (int i = numProductos - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int numProductos = this.lstTienda.SelectedItems.Count;
            for (int i = numProductos - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                string producto = this.lstTienda.SelectedItems[i].ToString();
                this.lstAlmacen.Items.Add(producto);
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //EXISTE UN METODO PARA AÑADIR MULTIPLES ELEMENTOS A UNA COLECCION
            //AddRange
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index - 1, producto);
            this.lstAlmacen.SelectedIndex = index - 1;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index + 1, producto);
            this.lstAlmacen.SelectedIndex = index + 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            if (index == 0)
            {
                this.btnUp.Enabled = false;
            }
            else
            {
                this.btnUp.Enabled = true;
            }
            if (index == this.lstAlmacen.Items.Count - 1)
            {
                this.btnDown.Enabled = false;
            }
            else
            {
                this.btnDown.Enabled = true;
            }
        }
    }
}
