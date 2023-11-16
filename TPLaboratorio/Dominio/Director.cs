namespace TPLaboratorio.Dominio
{
    public class Director
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Director()
        {
            id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
        }
        public Director(int idDirector, string nom, string ape)
        {
            id = idDirector;
            Nombre = nom;
            Apellido = ape;
        }
    }
}
