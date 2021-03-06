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

            var listaObjetos = engine.GetObjetosEscuela();

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
