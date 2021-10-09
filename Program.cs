using System;
using CoreEscuela.Enitdades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi",2012);
            escuela.Pais = "Mexico";
            escuela.Ciudad = "Naucalpan";
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
            Console.ReadLine();
        }
    }
}
