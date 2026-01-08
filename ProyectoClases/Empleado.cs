using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }


        protected int SalarioMinimo { get; set; }
        public Empleado() 
        {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1600;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public Empleado(string nombre, string apellidos)
            : base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor EMPLEADO con dos parámetros");
        }

        public Empleado(string nombre, string apellidos, int edad)
            : base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            Debug.WriteLine("Constructor EMPLEADO con tres parámetros");
        }
    }
}
