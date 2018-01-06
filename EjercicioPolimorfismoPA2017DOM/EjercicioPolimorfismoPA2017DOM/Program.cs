using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDatos<Estudiante> estudiantes = new ListaDatos<Estudiante>();
            ListaDatos<Curso> cursos = new ListaDatos<Curso>();

            for (int i = 1; i <= 5; i++)
            {
                Estudiante estudiante = new Estudiante();
                estudiante.NombreEstudiante = "Estudiante " + i;

                estudiantes.Agregar(estudiante);
            }

            for (int i = 1; i <= 5; i++)
            {
                Curso curso = new Curso();
                curso.NombreCurso = "Curso " + i;

                cursos.Agregar(curso);
            }

            // estudiantes.lista.ForEach(item => Console.WriteLine(item.NombreEstudiante));

            foreach (var item in estudiantes.lista)
            {
                Console.WriteLine(item.NombreEstudiante);
            }

            foreach (var item in cursos.lista)
            {
                Console.WriteLine(item.NombreCurso);
            }

            Console.ReadKey();
        }
    }
}
