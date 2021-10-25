using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Escuela: ObjetoEscuelaBase
    {
        public int añoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        //constructor de la clase o metodo
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais="", string ciudad="")
        {
            //asignacion de tuplas
            (Nombre, añoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;

        }

        //En C# todo es un objeto
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}";
        }

        //public Escuela(string nombre, int año) => (Nombre, añoDeCreacion) = (nombre, año);

    }
}
