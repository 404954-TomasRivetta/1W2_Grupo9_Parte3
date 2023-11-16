namespace TPLaboratorio.Dominio
{
    public class FormaPago
    {
        public int IdFormaPago { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
