using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);
            if (mes == 1)
            {
                mes = 13;
                anyo--;
            }else if (mes == 2)
            {
                mes = 14;
                anyo -= 1;
            }
            //            1.Multiplicar el Mes más 1 por 3 y dividirlo entre 5
            int op1 = ((mes + 1) * 3) / 5;
            //((6 + 1) * 3) / 5 = 4
            //    2.Dividir el año entre 4
            int op2 = anyo / 4;
            //1997 / 4 = 499
            //    3.Dividir el año entre 100
            int op3 = anyo / 100;
            //  1997 / 100 = 19
            //    4.Dividir el año entre 400
            int op4 = anyo / 400;
            //  1997 / 400 = 4
            //    5.Sumar el día, el doble del mes, el año, el resultado de la operación 1
            //    , el resultado de la operación 2
            //    , menos el resultado de la operación 3 más la operación 4 más 2.
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            //  15 + (6 * 2) + 1997 + 4 + 499 - 19 + 4 + 2 = 2514
            //    6.Dividir el resultado anterior entre 7.
            int op6 = op5 / 7;
            //2514 / 7 = 359
            //  7.Restar el número del paso 5 con el número del paso 6 por 7.
            int resultado = op5 - (op6 * 7);
            //     2514 – (359 * 7) = 1
            string diaSemana = "";
            if (resultado == 0)
            {
                diaSemana = "SABADO";
            }else if (resultado == 1)
            {
                diaSemana = "DOMINGO";
            }else if (resultado == 2)
            {
                diaSemana = "LUNES";
            }else if (resultado == 3)
            {
                diaSemana = "MARTES";
            }
            else if (resultado == 4)
            {
                diaSemana = "MIERCOLES";
            }
            else if (resultado == 5)
            {
                diaSemana = "JUEVES";
            }
            else if (resultado == 6)
            {
                diaSemana = "VIERNES";
            }
            else
            {
                diaSemana = "ERROR LOGICO";
            }
            this.lblResultado.Text = "El día de la semana es " + diaSemana;
        }
    }
}
