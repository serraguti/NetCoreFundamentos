using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> cajas;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.cajas = new List<CheckBox>();
            foreach (CheckBox chk in this.panel1.Controls)
            {
                this.cajas.Add(chk);
                chk.CheckedChanged += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            int suma = 0;
            foreach (CheckBox chk in this.cajas)
            {
                if (chk.Checked == true)
                {
                    int numero = int.Parse(chk.Text);
                    suma += numero;
                }
            }
            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox chk in this.cajas)
            {
                int num = random.Next(1, 99);
                chk.Text = num.ToString();
            }
        }
    }
}
