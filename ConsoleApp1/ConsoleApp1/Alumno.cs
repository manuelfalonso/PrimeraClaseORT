using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Alumno : Persona
    {
        public int NroLegajo { get; set; }
        public string Materia { get; set; }

        public Alumno()
        {

        }

        public Alumno(string materia)
        {
            Materia = materia;
        }

        public string MostrarDatos() 
        {
            string resultado;
            resultado = base.MostrarDatos() + " " + NroLegajo + " " + Materia;
            return resultado;
        }
    }
}
