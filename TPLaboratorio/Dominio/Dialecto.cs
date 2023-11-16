namespace TPLaboratorio.Dominio
{
    public class Dialecto
    {
        public int IdDialecto { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
