﻿using System;
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
            ListaString lsi = new ListaString();
            lsi.conectarBD();
            
            Console.ReadKey();
        }
    }
}