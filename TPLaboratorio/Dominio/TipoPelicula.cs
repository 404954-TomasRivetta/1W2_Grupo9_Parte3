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
