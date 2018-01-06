using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismoPA2017DOM
{
    class ListCursoEstudiante:IModificarLista
    {
        public void listarItems()
        {
            foreach (var item in estudiantes.lista)
            {
                Console.WriteLine(item.NombreEstudiante);
            }

            foreach (var item in cursos.lista)
            {
                Console.WriteLine(item.NombreCurso);
            }
        }
    }
}
