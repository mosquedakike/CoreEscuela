using System;
using System.Collections.Generic;
using CoreEscuela.App;
using CoreEscuela.Enitdades;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            ImprimirCursosEscuela(engine.Escuela);
            Console.ReadLine();
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("=====================");
            WriteLine("Cursos de la Escuela");
            WriteLine("=====================");

            foreach (var item in escuela.Cursos)
            {
                WriteLine($"Nombre: {item.Nombre}, Id: {item.UniqueId}");
            }
        }

    }
}
