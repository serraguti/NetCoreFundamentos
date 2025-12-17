using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {


        public Form14Metodos()
        {
            InitializeComponent();
            //ArrayList botones = new ArrayList();
            //botones.Add(this.btnDobleRef);
            //botones.Add(this.btnDobleValor);
            //botones.Add(this.btnObjetoRef);
            //foreach (Button num in botones)
            //{

            //}
        }

        //RECIBIMOS UN WRAPPER POR VALOR
        void GetDobleValor(int numero)
        {
            numero = numero * 2;
        }

        int GetDoble(int numero)
        {
            return numero * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int resultado = this.GetDoble(num);

            this.GetDobleValor(num);
            this.lblResultado.Text = num.ToString();
        }


        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.LightGoldenrodYellow;
        }

        private void btnObjetoRef_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleRef);
            this.CambiarColor(this.btnDobleValor);
        }

        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        private void btnDobleRef_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //CON REF, LAS DOS VARIABLES APUNTAN AL MISMO ESPACIO DE MEMORIA
            this.GetDobleReferencia(ref num);
            this.lblResultado.Text = num.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TENEMOS UNA ENUMERACION LLAMADA Keys QUE NOS PERMITE 
            //ACCEDER A LOS CODIGOS DEL TECLADO
            //DEBEMOS SABER EL CODIGO ASCII DE LA TECLA DE BORRAR
            char teclaBorrar = (char)Keys.Back;
            //EXISTE ALGUNA FORMA DE SABER SI UN CHAR ES UN NUMERO????
            if (char.IsDigit(e.KeyChar) == false 
                && e.KeyChar != teclaBorrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEY
                e.Handled = true;
            }
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEY
                e.Handled = true;
            }
        }
    }
}
