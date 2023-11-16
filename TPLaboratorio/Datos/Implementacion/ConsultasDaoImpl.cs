using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLaboratorio.Datos.Interfaz;
using TPLaboratorio.Dominio;

namespace TPLaboratorio.Datos.Implementacion
{
    public class ConsultasDaoImpl : IConsultasDao
    {        
        public List<Comprobante> TraerComprobantesFiltrados(Comprobante c)
        {
            List<Comprobante> lComprobantes = new List<Comprobante>();
            List<Parametro> lParametros = new List<Parametro>();

            
            lParametros.Add(new Parametro("@id_comprobante", c.IdComprobante != 0 ? (object)c.IdComprobante : DBNull.Value));
            lParametros.Add(new Parametro("@id_cliente", c.IdCliente != 0 ? (object)c.IdCliente : DBNull.Value));
            lParametros.Add(new Parametro("@id_forma_pago", c.IdForma_pago != 0 ? (object)c.IdForma_pago : DBNull.Value));
            lParametros.Add(new Parametro("@id_empleado", c.IdEmpleado != 0 ? (object)c.IdEmpleado : DBNull.Value));
            lParametros.Add(new Parametro("@cant_entradas_1", c.CantEntradasDesde != 0 ? (object)c.CantEntradasDesde : DBNull.Value));
            lParametros.Add(new Parametro("@cant_entradas_2", c.CantEntradasHasta != 0 ? (object)c.CantEntradasHasta : DBNull.Value));
            lParametros.Add(new Parametro("@importe_Desde",c.ImporteDesde != 0 ? (object)c.ImporteDesde : DBNull.Value));
            lParametros.Add(new Parametro("@importe_hasta", c.ImporteHasta != 0 ? (object)c.ImporteHasta : DBNull.Value));

            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_COMPROBANTES_FILTRADOS", lParametros);

            foreach (DataRow fila in tabla.Rows)
            {
                Comprobante co = new Comprobante();

                    co.IdComprobante = int.Parse(fila["id_comprobante"].ToString());
                    co.IdCliente = int.Parse(fila["id_cliente"].ToString());
                    co.IdForma_pago = int.Parse(fila["id_forma_pago"].ToString());
                    co.IdEmpleado = int.Parse(fila["id_empleado"].ToString());
                    co.CantEntradas = int.Parse(fila["cant_entradas"].ToString());
                    co.NombreCliente = fila["Cliente"].ToString();
                    co.NombreEmpleado = fila["Empleado"].ToString();
                    co.FormaPago = fila["Forma_Pago"].ToString();
                    co.Importe = decimal.Parse(fila["Importe"].ToString());                    
                lComprobantes.Add(co);
            }

            return lComprobantes;
        }
        
        public List<Director> obtenerDirectores()
        {
            List<Director> lDirectores = new List<Director>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_DIRECTORES");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = Convert.ToInt32(fila[0]);
                string nombre = fila[1].ToString();
                string apellido = fila[2].ToString();
                Director d = new Director(codigo, nombre, apellido);
                lDirectores.Add(d);
            }
            return lDirectores;
        }

        public List<TipoPelicula> ObtenerGeneros()
        {
            List<TipoPelicula> lGeneros = new List<TipoPelicula>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_GENEROS");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = Convert.ToInt32(fila[0]);
                string descripcion = fila[1].ToString();
                TipoPelicula g = new TipoPelicula(id, descripcion);
                lGeneros.Add(g);
            }
            return lGeneros;
        }

    }
}
