using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnComprobarEmail_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            //            	• Exista @
            //	• @ ni al inicio ni al final
            //	• No exista más de una @
            //	• Existe un punto
            //	• Un punto después de la @
            //Dominio de 2 a 3 caracteres
            if (email.Contains("@") == false)
            {
                this.lblResultado.Text = "No existe @";
            }
            else if (email.IndexOf("@") == 0 || email.EndsWith("@") == true)
            {
                this.lblResultado.Text = "@ al inicio o al final";
                //}else if (email.IndexOf("@", email.IndexOf("@") + 1) != -1)
            } else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lblResultado.Text = "Existe más de una @";
            } else if (email.IndexOf(".") == -1)
            {
                this.lblResultado.Text = "No existe punto";
            } else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lblResultado.Text = "Debe existir punto despues de @";
            }
            else
            {
                //com
                //es
                int ultimoPunto = email.LastIndexOf(".") + 1;
                string dominio = email.Substring(ultimoPunto);
                if (dominio.Length >= 2 && dominio.Length <= 3)
                {
                    this.lblResultado.Text = "Email CORRECTO";
                }
                else
                {
                    this.lblResultado.Text = "Dominio debe ser de 2 a 3 caracteres";
                }
            }
        }
    }
}
