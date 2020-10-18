using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.DNI = 34577276;
            persona.Nombre = "Manuel";
            persona.Apellido = "Apeliido";
            Console.WriteLine(persona.MostrarDatos());

            Alumno alumno = new Alumno();
            alumno.DNI = 44555666;
            alumno.Nombre = "Pepe";
            alumno.Apellido = "Gomenz";
            alumno.NroLegajo = 123456;
            alumno.Materia = "NT1";

            Console.WriteLine(alumno.MostrarDatos());

            Console.ReadKey();
        }
    }
}
