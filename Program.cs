using System;
using System.Collections.Generic;
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.DibujarTitulo("BIENVENIDOS A LA ESCUELA");

            ImprimirCursosEscuela(engine.Escuela);

            Printer.DibujarLinea(50);
            Printer.DibujarTitulo("Pruebas de Polimorfismo");

            var alumnoTest = new Alumno { Nombre = "Claire Underwood" };

            ObjetoEscuelaBase ob = alumnoTest;
            Printer.DibujarTitulo($"Alumno");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"Alumno: {alumnoTest.UniqueId}");
            WriteLine($"Alumno: {alumnoTest.GetType()}");

            Printer.DibujarTitulo("ObjetoEscuela");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine($"Alumno: {ob.UniqueId}");
            WriteLine($"Alumno: {ob.GetType()}");

            Console.ReadLine();
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarTitulo("Cursos de la Escuela");

            foreach (var item in escuela.Cursos)
            {
                WriteLine($"Nombre: {item.Nombre}, Id: {item.UniqueId}");
            }
        }

    }
}
