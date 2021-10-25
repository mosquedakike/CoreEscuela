using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.App
{
    public sealed class EscuelaEngine
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
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluacion
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura(){Nombre="Ingles"},
                    new Asignatura(){Nombre="Matematicas"},
                    new Asignatura(){Nombre="Fundamentos de Fisica"},
                    new Asignatura(){Nombre="Logica de Programacion"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnos(int cantidad)
        {
            string[] FirstName = { "Jose", "Luis", "Lirya", "Emmma", "Yolanda", "Rodrigo", "Cecilia" };
            string[] SecondName = { "Miguel", "Enrique", "Angel", "Jon", "Freddy", "Antonio", "Itzel" };
            string[] LastName = { "Hernández", "Mosqueda", "Navarrete", "Orozco", "Guzman", "Valencia", "Peñaloza" };

            var listaAlumnos = from n1 in FirstName
                               from n2 in SecondName
                               from n3 in LastName
                               select new Alumno { Nombre = $"{n1} {n2} {n3}" };
            return listaAlumnos.OrderBy((alumno)=>alumno.UniqueId).Take(cantidad).ToList();
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

            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 20);
                curso.Alumnos = GenerarAlumnos(cantidadRandom);
            }
        }
    }
}
