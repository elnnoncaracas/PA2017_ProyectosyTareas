using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Autor : Usuario
    {
       string nombre { get; set; }
        string apellido { get; set; }
        string titulo { get; set;}

        public void redactar(int idart, string titulo, string descripcion, string texto) {

            this.nombre = Nombre;
            this.apellido = Apellido;
            this.titulo= titulo;

        
        }

    }
}
