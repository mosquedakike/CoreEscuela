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
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            var lista = new List<Evaluaciones>();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        Random rnd = new Random();
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluaciones
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{1+1}",
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
                    new Asignatura(){Nombre="Ingles I"},
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
            return listaAlumnos.OrderBy((alumno)=> alumno.UniqueId).Take(cantidad).ToList();
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
