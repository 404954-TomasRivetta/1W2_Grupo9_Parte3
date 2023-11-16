using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLaboratorio.Datos.Implementacion;
using TPLaboratorio.Datos.Interfaz;
using TPLaboratorio.Dominio;
using TPLaboratorio.Servicio.Interfaz;

namespace TPLaboratorio.Servicio.Implementacion
{
    public class ServicioConsultasImpl: IServicioConsultas
    {
        IConsultasDao dao = null;
        public ServicioConsultasImpl()
        {
            dao = new ConsultasDaoImpl();
        }

        public List<Comprobante> TraerComprobantesFiltrados(Comprobante c)
        {
            return dao.TraerComprobantesFiltrados(c);
        }

        public List<Director> ObtenerDirectores()
        {
            return dao.ObtenerDirectores();
        }

        public List<TipoPelicula> ObtenerGeneros()
        {
            return dao.ObtenerGeneros();
        }
        public List<Cliente> TraerClientes()
        {
            return dao.TraerClientes();
        }
        public List<Empleado> TraerEmpleados()
        {
            return dao.TraerEmpleado();
        }
        public List<FormaPago> TraerFormaPago()
        {
            return dao.TraerFormaPagos();
        }
        DataTable IServicioConsultas.TraerPeliculaFiltrada(DateTime fechaDesde, DateTime fechaHasta)
        {
            return dao.TraerPeliculaFiltrada(fechaDesde, fechaHasta);
        }

        //Implementan el mismo método hecho en el dao, usando el propio dao...
    }
}
