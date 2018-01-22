using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_ConexionBDPolimorfHerencia
{
    class Lresultado<T>
    {
        public List<T> liRes { get; set; }
        public void Lista()
        {
            this.liRes = new List<T>();
        }

        public void Agregar(T item)
        {
            liRes.Add(item);
        }

    }
}
