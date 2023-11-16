using System;
using System.Collections.Generic;
using System.Data;
using TPLaboratorio.Dominio;

namespace TPLaboratorio.Datos.Interfaz
{
    public interface IConsultasDao
    {
        //Cada uno hará un método para hacer la consulta que quiera...
        List<Comprobante> TraerComprobantesFiltrados(Comprobante c);//rodri

        DataTable TraerPeliculaFiltrada(DateTime fechaDesde, DateTime fechaHasta); // santi alexis tomi

        DataTable TraerReservaFiltrada(string nombreReserva, DateTime fechaReserva); // santi alexis tomi

        List<Cliente> TraerClientes();
        List<Empleado> TraerEmpleado();
        List<FormaPago> TraerFormaPagos();
        List<Director> ObtenerDirectores(); //nico valen
        List<TipoPelicula> ObtenerGeneros(); //nico valen
    }
}
