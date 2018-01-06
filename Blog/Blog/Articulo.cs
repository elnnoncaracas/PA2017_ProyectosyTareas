using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
     class Articulo:Autor
    {
        string titulo { get; set; }
        string descripcion { get; set; }
        string tipo { get; set; }
        string autorNA { get; set; }
        public string autor()
        {
            string autorNA = Nombre + Apellido;
            return autorNA;
        }
        
        public void esttipo(string tipo, string _titulo, string _descripcion) {

            this.titulo = _titulo;
            this.descripcion = _descripcion;
            this.tipo = tipo;
            
        }

        public void mostrarInfo()
        {
            string mensaje = "El articulo se llama: " + titulo + "\n" + "Creado por: " + autorNA + "\n Descripcion:" + descripcion;
            Console.WriteLine(mensaje);
        }
    }
}
