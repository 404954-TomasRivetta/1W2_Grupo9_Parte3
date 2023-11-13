using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLaboratorio.Dominio
{
    public class Actor
    {
        public int IdActor { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
        public Actor()
        {
            IdActor = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
        }
        public Actor(int id, string nom, string ape)
        {
            IdActor = id;
            Nombre = nom;
            Apellido = ape;
        }
    }
}
