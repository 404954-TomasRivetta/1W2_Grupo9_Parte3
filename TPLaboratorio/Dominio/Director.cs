﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLaboratorio.Dominio
{
    public class Director
    {
        public int IdDirector { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Director()
        {
            IdDirector = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
        }
        public Director(int id, string nom, string ape)
        {
            IdDirector = id;
            Nombre = nom;
            Apellido = ape;
        }
    }
}
