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
            Usuario calu = new Usuario();
            calu.nombre = "chepe";
            Console.WriteLine(calu.nombre);
            Console.ReadKey();
        }
    }
}
