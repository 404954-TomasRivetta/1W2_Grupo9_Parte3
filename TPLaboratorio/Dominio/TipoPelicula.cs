using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLaboratorio.Dominio
{
    public class TipoPelicula
    {
        public int id { get; set; }

        public TipoPelicula(int id, string descripcion)
        {
            this.id = id;
            Nombre = descripcion;
        }

        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
