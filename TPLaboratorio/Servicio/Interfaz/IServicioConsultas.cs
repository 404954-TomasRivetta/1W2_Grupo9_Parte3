using System;
using System.Collections.Generic;
using System.Data;
using TPLaboratorio.Dominio;

namespace TPLaboratorio.Servicio.Interfaz
{
    public interface IServicioConsultas
    {
        List<Comprobante> TraerComprobantesFiltrados(Comprobante c);//Rodri
        List<Director> ObtenerDirectores(); //nico valen
        List<TipoPelicula> ObtenerGeneros(); //nico valen

        DataTable TraerPeliculaFiltrada(DateTime fechaDesde, DateTime fechaHasta); // santi alexis tomi

        DataTable TraerReservaFiltrada(string nombreReserva, DateTime fechaReserva); // santi alexis tomi

        List<Cliente> TraerClientes();
        List<Empleado> TraerEmpleados();
        List<FormaPago> TraerFormaPago();
        //Acá simplemente pondrán el mismo método hecho en el dao...
        DataTable TraerDirector(DateTime fechaLimite, int idDir, int idG);
    }
}
