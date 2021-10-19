using System;
using CoreEscuela.Enitdades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi", 2012, TiposEscuela.Secundaria, pais: "Canada", ciudad: "Montreal");

            escuela.Cursos = new Curso[]
            {
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"}
            };

            ImprimirCursosEscuela(escuela);

            //Console.WriteLine(escuela);
            //Console.WriteLine("*********************************************************");
            //Console.WriteLine("while");
            //ImprimirCursosWhile(arregloCursos);
            //Console.WriteLine("do while");
            //ImprimirCursosDoWhile(arregloCursos);
            //Console.WriteLine("for");
            //ImprimirCursosFor(arregloCursos);
            //Console.WriteLine("forEach");
            //ImprimirCursosFor(arregloCursos);

            //Console.WriteLine("*********************************************************");
            //Console.WriteLine("foreach");
            //foreach (var item in arregloCursos)
            //{
            //    Console.WriteLine($"Nombre: {item.Nombre}, Id: {item.UniqueId}");
            //}

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

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;

            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;

            do
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($"Nombre: {arregloCursos[i].Nombre}, Id: {arregloCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var item in arregloCursos)
            {
                Console.WriteLine($"Nombre: {item.Nombre}, Id: {item.UniqueId}");
            }
        }
    }
}
