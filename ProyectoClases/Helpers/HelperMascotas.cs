using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        //QUEREMOS ALMACENAR DE FORMA FISICA LAS MASCOTAS EN FILES
        private HelperFiles helper;
        private string path;

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = "mascotas.txt";
        }

        //CONVERTIR EL STRING DEL READ A LIST
        private void ConvertirMascotasList(string data)
        {
            //GARFIELD,GATO@PLUTO,PERRO
            this.Mascotas.Clear();
            //SEPARAMOS CADA MASCOTA CON @
            string[] datosMascota = data.Split('@');
            foreach (string stringMascota in datosMascota)
            {
                //SEPARAMOS LAS PROPIEDADES MEDIANTE ,
                string[] propiedades = stringMascota.Split(',');
                //CONVERTIMOS EL TRISTE STRING EN OBJETOS
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        //EL PROGRAMADOR ESCRIBA Read y LEEMOS UN STRING Y RELLENAMOS LA COLECCION
        public async Task ReadMascotasAsync()
        {
            //LEEMOS EL FICHERO DE MASCOTAS
            string data = await this.helper.ReadFileAsync(this.path);
            //CONVERTIMOS EL STRING EN LIST
            this.ConvertirMascotasList(data);
        }

        //EL PROGRAMADOR ESCRIBA Write y GUARDAMOS LAS MASCOTAS
        public async Task WriteMascotasAsync()
        {
            //CONVERTIMOS LA COLECCION A STRING
            string data = this.ConvertirMascotasString();
            //ESCRIBIMOS LOS DATOS EN FILE
            await this.helper.WriteFileAsync(this.path, data);
        }

        //CONVERTIMOS LA COLECCION A STRING
        private string ConvertirMascotasString()
        {
            //GARFIELD,GATO@PLUTO,PERRO
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                //SEPARAMOS LAS PROPIEDADES MEDIANTE ,
                //PLUTO,PERRO
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                //SEPARAMOS CADA OBJETO STRING DE MASCOTA
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }


    }
}
