using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_ConexionBDPolimorfHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hola, por favor selecciona una opcion: \n\n\n");
            Console.WriteLine("\t\t\t1. Ejecutar Consulta SQL por Defecto");
            Console.WriteLine("\t\t\t2. Escribir consulta SQL Personalizada");
            int vswitch = Int32.Parse((Console.ReadLine()));
            switch (vswitch) {
                case 1:

                        ListaString lsi = new ListaString();
                        lsi.conectarBD();
                        Console.WriteLine("Presiona cualquier tecla para continuar");
                        Console.ReadKey();
                        Mdatos showdata = new Mdatos();
                        showdata.MdatosDB();
                        Console.WriteLine("Presiona cualquier tecla para continuar");
                        lsi.desconectarBD();
                        Console.ReadKey();
                    break;
                case 2:
                        ListaString lscarg = new ListaString();
                        lscarg.conectarBD();
                        Console.WriteLine("Presiona cualquier tecla para continuar");
                        Console.ReadKey();
                        Mdatos showdt = new Mdatos();
                        Console.WriteLine("Ingresa tu consulta SQL _Postgre\n La unica tabla que se puede consultar es: \"public.spatial_ref_sys\"");
                        string consulta = Console.ReadLine();
                        showdt.MdatosDB(consulta);
                        Console.ReadKey();
                        lscarg.desconectarBD();
                    break;
                default:
                    Console.WriteLine("Opcion no valida para este menú");
                    break;
        }
        }
    }
}
