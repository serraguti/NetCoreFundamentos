using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;

namespace ProyectoClases
{
    #region ENUMERACIONES
    //LAS ENUMERACIONES ESTAN DENTRO DEL NAMESPACE
    public enum TipoGenero { Masculino = 0, Femenino = 1 }
    public enum Paises { España, Francia, Alemania, Andorra, Colombia}
    #endregion

    public class Persona
    {
        #region CONSTRUCTORES

        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacío");
        }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor PERSONA con dos parámetros");
        }

        #endregion

        #region PROPIEDADES

        private List<string> Descripciones { get; set; }

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this.Descripciones[indice]; }
            set {
                this.Descripciones.Add(value);
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set { 
                if (value != TipoGenero.Femenino && 
                    value != TipoGenero.Masculino)
                {
                    throw new Exception("Donde vas, listo...");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }


        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //CAMPO DE PROPIEDAD
        private int _Edad;
        public int Edad
        {
            //DEVOLVEMOS EL VALOR
            get { return this._Edad; }
            //ESTABLECEMOS UN VALOR
            //PROGRAMADOR: person.Edad = -25;
            set
            {
                if (value < 0)
                {
                    //NO NOS GUSTA.  ERROR
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        #endregion

        #region METODOS 

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }

        public string GetNombreCompleto(int num1)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }

        public string GetNombreCompleto(int num1, int num2)
        {
            return this.GetNombreCompleto().ToLower();
        }

        public void GetNombreCompleto(string dato) { }
        #endregion
    }
}
