using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CoreEscuela.Util
{
    public class Printer
    {
        public static void DibujarLinea(int tam = 20) 
        {
            WriteLine("".PadLeft(tam,'='));
        }

        public static void DibujarTitulo(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }
    }
}
