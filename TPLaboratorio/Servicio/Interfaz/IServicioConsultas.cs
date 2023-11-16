using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLaboratorio.Dominio;

namespace TPLaboratorio.Servicio.Interfaz
{
    public interface IServicioConsultas
    {
        List<Comprobante> TraerComprobantesFiltrados(Comprobante c);//Rodri
        List<Director> ObtenerDirectores(); //nico valen
        List<TipoPelicula> ObtenerGeneros(); //nico valen

        DataTable TraerPeliculaFiltrada(DateTime fechaDesde, DateTime fechaHasta);
        //Acá simplemente pondrán el mismo método hecho en el dao...
    }
}
