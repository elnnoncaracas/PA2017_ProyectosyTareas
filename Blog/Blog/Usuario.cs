﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Usuario
    {
        public int id;
        public string nombre, apellido, email;

        public Usuario(){}
        public Usuario(int id, string nombre, string apellido, string email)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Id = id;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        

    }
}
