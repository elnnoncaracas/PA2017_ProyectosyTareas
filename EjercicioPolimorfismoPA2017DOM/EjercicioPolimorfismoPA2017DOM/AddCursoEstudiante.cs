using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismoPA2017DOM
{

    class AddCursoEstudiante:IModificarLista
    {
        class Curso
        {
            public string NombreCurso { get; set; }
        }
        class Estudiante
        {
            public string NombreEstudiante { get; set; }
        }
       class ListaDatos<T>
        {
            public List<T> lista { get; set; }
            public ListaDatos()
            {
                this.lista = new List<T>();
            }

            public void Agregar(T item)
            {
                lista.Add(item);
            }
        }
        public void agregarItems()
        {

            for (int i = 1; i <= 5; i++)
            {
                Estudiante estudiante = new Estudiante();
                estudiante.NombreEstudiante = "Estudiante " + i;

                estudiante.Agregar(estudiante);
            }

            for (int i = 1; i <= 5; i++)
            {
                Curso curso = new Curso();
                curso.NombreCurso = "Curso " + i;

                curso.Agregar(curso);
            }

        }
    }
}
