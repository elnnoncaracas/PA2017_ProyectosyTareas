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
      public  string titulo { get; set;}
      public  string descripcion { get; set; }

        public void redactar() { }
        public void redactar(int idart, string titulo, string descripcion, string nombre, string apellido) {

            this.nombre = Nombre;
            this.apellido = Apellido;
            this.titulo= titulo;
            this.descripcion = descripcion;

        
        }

    }
}
