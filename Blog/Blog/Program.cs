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
            Usuario calu = new Usuario(1,"juanito","caso","olakease@guis.se");
            Console.WriteLine(calu.Id+calu.Nombre+calu.Apellido);
            Console.ReadKey();
        }
    }
}
