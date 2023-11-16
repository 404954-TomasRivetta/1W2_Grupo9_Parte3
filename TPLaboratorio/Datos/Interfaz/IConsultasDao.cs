using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLaboratorio.Dominio;

namespace TPLaboratorio.Datos.Interfaz
{
    public interface IConsultasDao
    {
        //Cada uno hará un método para hacer la consulta que quiera...
        List<Comprobante> TraerComprobantesFiltrados(Comprobante c);//rodri

        DataTable TraerPeliculaFiltrada(DateTime fechaDesde, DateTime fechaHasta);
        List<Cliente> TraerClientes();
        List<Empleado> TraerEmpleado();
        List<FormaPago> TraerFormaPagos();
        List<Director> ObtenerDirectores(); //nico valen
        List<TipoPelicula> ObtenerGeneros(); //nico valen
    }
}
