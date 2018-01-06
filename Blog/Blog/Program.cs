using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Usuario Cal = new Usuario();
           // Cal.comentar("Kal - ","El","Oie ke zukulento");
            //Console.WriteLine("Lo que"+"\t"+Cal.Nombre+Cal.Apellido+" Comento fue: "+Cal.Comentario);
            //Console.ReadKey();
           Autor ahh = new Autor();
            //ahh.comentar("El Autor: ","hey","Los autores tambien comentan");
           ahh.redactar(1,"La redaccion de blogs","Aprende a redactar un blog","Juanito","Verde");
            //Console.WriteLine(ahh.Comentario+"\n");
            //Console.WriteLine(ahh.descripcion);
            
            //ahh.editar("Ingresa algo al blog","Comita... ya ta compuesto");
            Console.ReadKey();
            Articulo achu = new Articulo();
            achu.esttipo("Juanito y los frijoles magicos","Anonimo","Breve historia de un sujeto anonimo que no se sabe quien es pero que no hace nada");
            achu.mostrarInfo();
            Console.ReadKey();
        }
    }
}
