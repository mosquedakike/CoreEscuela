using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Enitdades
{
    public class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return "Copia:" + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int añoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        //constructor de la clase o metodo
        public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            añoDeCreacion = año;
        }

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
