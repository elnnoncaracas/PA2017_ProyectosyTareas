using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismoPA2017DOM
{
    class ListaDatos<T>
    {
        public List<T> lista { get; set; }
        public ListaDatos()
        {
            this.lista = new List<T>();
        }

        public void Agregar(T item)
        {
            lista.Add(item);
        }
    }
}
