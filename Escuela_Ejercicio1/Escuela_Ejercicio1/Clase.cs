using System;
using System.Collections.Generic;

namespace Escuela_Ejercicio1
{
    public class Clase
    {
        public string Nombre { get; set; }
        public string IdentificadorUnico { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public List<Profesor> Profesores { get; set; }

        public Clase(string nombre, string identificadorUnico)
        {
            Nombre = nombre;
            IdentificadorUnico = identificadorUnico;
            Estudiantes = new List<Estudiante>();
            Profesores = new List<Profesor>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }

        public void ImprimirInformacion()
        {
            Console.WriteLine($"Clase: {Nombre}");
            Console.WriteLine($"Identificador único: {IdentificadorUnico}");


            Console.WriteLine("\nEstudiantes:");
            foreach (var estudiante in Estudiantes)
            {
                Console.WriteLine($"- {estudiante.Nombre}, numero {estudiante.Numero}");
            }

            Console.WriteLine("\nProfesores:");
            foreach (var profesor in Profesores)
            {
               Console.WriteLine($"\nProf: {profesor.Nombre}");
                Console.WriteLine("\nCursos que imparte:");
                foreach (var curso in profesor.Cursos)
                {
                    Console.WriteLine($"- {curso.Nombre} (Clases: {curso.RecuentoClases}, Ejercicios: {curso.RecuentoEjercicios})");
                }
            }
        }
    }
}
