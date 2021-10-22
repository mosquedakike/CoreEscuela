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

            CargarCursos();
            foreach (var curso in Escuela.Cursos)
            {
                curso.Alumnos.AddRange(CargarAlumnos());
            }
            var listaA = CargarAlumnos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            //throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura(){Nombre="Ingles I"},
                    new Asignatura(){Nombre="Matematicas"},
                    new Asignatura(){Nombre="Fundamentos de Fisica"},
                    new Asignatura(){Nombre="Logica de Programacion"}
                };
                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private IEnumerable<Alumno> CargarAlumnos()
        {
            string[] FirstName = { "Jose", "Luis", "Lirya", "Emmma", "Yolanda", "Rodrigo", "Cecilia" };
            string[] SecondName = { "Miguel", "Enrique", "Angel", "Jon", "Freddy", "Antonio", "Itzel" };
            string[] LastName = { "Hernández", "Mosqueda", "Navarrete", "Orozco", "Guzman", "Valencia", "Peñaloza" };

            var listaAlumnos = from n1 in FirstName
                               from n2 in SecondName
                               from n3 in LastName
                               select new Alumno { Nombre = $"{n1} {n2} {n3}" };
            return listaAlumnos;
        }

        private void CargarCursos()
        {
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
