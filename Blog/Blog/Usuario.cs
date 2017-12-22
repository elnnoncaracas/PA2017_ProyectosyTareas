using System;
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

        public int Id { get; }
        public string Nombre { get; }
        public string Apellido { get; }
        public string Email { get; }
        

    }
}
