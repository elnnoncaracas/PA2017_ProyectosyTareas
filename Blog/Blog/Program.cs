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
            Cal.comentar("Kal - ","El","Oie ke zukulento");
            Console.WriteLine("Lo que"+"\t"+Cal.Nombre+Cal.Apellido+" Comento fue: "+Cal.Comentario);
            Console.ReadKey();

        }
    }
}
