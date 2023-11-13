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

        

        //Implementan el mismo método hecho en el dao, usando el propio dao...
    }
}
