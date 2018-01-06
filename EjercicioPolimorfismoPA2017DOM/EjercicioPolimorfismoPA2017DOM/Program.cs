using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismoPA2017DOM
{
    class Program
    {
        static void Main(string[] args)
        {

            AddCursoEstudiante cevar = new AddCursoEstudiante();

            cevar.agregarItems();

            ListCursoEstudiante licevar = new ListCursoEstudiante();

            licevar.listarItems();

            Console.ReadKey();
        }
    }
}
