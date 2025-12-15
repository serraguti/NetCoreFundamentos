using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            int suma = 0;
            //RECORREMOS TODO EL CONTENIDO DE TEXTONUMEROS
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                //RECUPERAMOS CADA CARACTER DEL TEXTO
                char caracter = textoNumeros[i];
                //CONVERTIMOS CADA CARACTER A NUMERO
                //ESTA CONVERSION AUTOMATICA RECUPERA EL ASCII
                //int numero = caracter;
                //NECESITAMOS EL LITERAL DEL NUMERO "1"
                //int numero = int.Parse(caracter.ToString());
                //EXISTE UNA CLASE PARA CONVERTIR ENTRE TIPOS DE DATO
                //EN MOMENTOS ESPECIALES
                int numero = Convert.ToInt32(caracter.ToString());
                suma += numero;
            }
            this.lblResultado.Text = "La suma de " + textoNumeros + " es " + suma;
        }
    }
}
