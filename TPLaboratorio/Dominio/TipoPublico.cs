﻿namespace TPLaboratorio.Dominio
{
    public class TipoPublico
    {
        public int IdTipoPublico { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
