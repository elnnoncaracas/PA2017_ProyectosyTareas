using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Autor : Usuario
    {
       private string nombre { get; set; }
       private string apellido { get; set; }
      public  string titulo { get; set;}
      public  string descripcion { get; set; }

        public void redactar() { }
        public void redactar(int idart, string titulo, string descripcion, string nombre, string apellido) {

            this.nombre = Nombre;
            this.apellido = Apellido;
            this.titulo= titulo;
            this.descripcion = descripcion;

        
        }

        public void editar() { }
        public void editar(string titulo, string descripcion)
        {
            Console.WriteLine("El Titulo actual es: " + this.titulo);
            Console.WriteLine("La descripcion dice: " + this.descripcion);
            this.descripcion = descripcion;
            this.titulo = titulo;

            Console.WriteLine("El Titulo nuevo es: " + this.titulo);
            Console.WriteLine("La descripcion nueva dice: " + this.descripcion);

        }
    }
}
