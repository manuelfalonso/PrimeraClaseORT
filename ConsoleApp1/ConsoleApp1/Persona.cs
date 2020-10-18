using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Persona
    {
        public int DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public string MostrarDatos()
        {
            string resultado;
            resultado = "Datos: " + DNI + " " + Apellido + " " + Nombre;
            return resultado;
        }
    }
}
