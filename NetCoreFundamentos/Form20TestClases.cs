using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Nombre = "Alumno";
            person.Apellidos = "Reyes";
            person.Edad = 25;
            //person.Descripciones[0] = "Hello";

            //person[0] = "Vamos 1";
            //person[1] = "Vamos 2";
            person.Genero = TipoGenero.Femenino;

            this.lstClases.Items.Add("Genero: " + person.Genero);
            person.Nacionalidad = Paises.Andorra;

            this.lstClases.Items.Add("Nombre: " + person.Nombre
                + ", Apellidos: " + person.Apellidos
                + ", Edad: " + person.Edad);

            this.lstClases.Items.Add(
                person.GetNombreCompleto(true)
                );

            person.Domicilio = new Direccion("Avenida Enero", "Lugo");
            person.Domicilio.CodigoPostal = 28003;
            this.lstClases.Items.Add("Dirección: "
                + person.Domicilio.Calle + ", "
                + person.Domicilio.Ciudad + ", "
                + person.Domicilio.CodigoPostal);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado emp = new Empleado("Nombre", "Apellidos");
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            this.lstClases.Items.Add("Vacas Empleado: " + emp.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");
            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellidos = "Dire";
            this.lstClases.Items.Add("Vacas Director: " + dire.GetDiasVacaciones());
            this.lstClases.Items.Add("Director: " + dire.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dire.GetSalarioMinimo() + "€");
        }
    }
}
