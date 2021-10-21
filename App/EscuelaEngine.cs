using CoreEscuela.Enitdades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {
            
        }

        public void Inicializar()
        {
            Escuela = new Escuela(
                "Platzi", 2012, TiposEscuela.Secundaria,
                pais: "Canada", ciudad: "Montreal"
                );

            Escuela.Cursos = new List<Curso>()
            {
                new Curso(){Nombre = "101", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre = "201", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre = "301", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre = "401", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre = "501", Jornada=TiposJornada.Mañana},
            };
        }
    }
}
