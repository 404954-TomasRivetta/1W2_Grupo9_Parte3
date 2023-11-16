using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLaboratorio.Dominio
{
    public class Comprobante
    {
        public int IdCliente { get; set; }
        public int IdForma_pago { get; set; }
        public int IdEmpleado { get; set; }
        public int CantEntradasDesde { get; set; }
        public int CantEntradasHasta { get; set; }
        public int CantEntradas { get; set; }
        public List<Ticket> lTickets { get; set; }
        public int IdComprobante { get;set; }
        public string NombreCliente { get; set; }
        public string NombreEmpleado { get; set; }
        public string FormaPago { get; set; }
        public decimal ImporteDesde { get; set; }
        public decimal ImporteHasta { get; set; }
        public decimal Importe { get; set; }
        public Comprobante()
        {
            lTickets = new List<Ticket>();
        }
        public Comprobante(int idCliente,int idFormaPago,int idEmpleado,int cantEntradasDesde,int cantEntradasHasta,/*int cantEntradas,*/int idComprobante)        
        {
            IdCliente=idCliente;
            IdForma_pago=idFormaPago;
            IdEmpleado=idEmpleado;
            CantEntradasDesde = cantEntradasDesde;
            CantEntradasHasta=cantEntradasHasta;
            //CantEntradas=cantEntradas;
            IdComprobante=idComprobante;
        }
        public Comprobante(int idCli, int idFormaPago, int idEmpleado, int cantDesde, int cantHasta, int idComp,decimal importeDesde,decimal importeHasta)
        {
            IdCliente = idCli;
            IdForma_pago = idFormaPago;
            IdEmpleado=idEmpleado;
            CantEntradasDesde=cantDesde;
            CantEntradasHasta =cantHasta;
            IdComprobante=idComp;
            ImporteDesde = importeDesde;
            ImporteHasta = importeHasta;
        }
        public Comprobante(int idCliente, int idFormaPago, int idEmpleado, int cantEntradasDesde, int cantEntradasHasta,int idComprobante, string nombreCliente, string nombreEmpleado, string formaPago, decimal importeDesde, decimal importeHasta, decimal importe)
        {
            IdCliente = idCliente;
            IdForma_pago = idFormaPago;
            IdEmpleado = idEmpleado;
            CantEntradasDesde = cantEntradasDesde;
            CantEntradasHasta = cantEntradasHasta;
            //CantEntradas=cantEntradas;
            IdComprobante = idComprobante;
            NombreCliente = nombreCliente;
            FormaPago = formaPago;
            NombreEmpleado = nombreEmpleado;
            ImporteDesde = importeDesde;
            ImporteHasta = importeHasta;
            Importe = importe;
        }
        public Comprobante(int idComprobante, int idCliente, int idEmpleado, int cantEntradasDesde, int cantEntradasHasta,decimal importeDesde, decimal importeHasta)
        {
            IdCliente = idCliente;
            IdEmpleado = idEmpleado;
            CantEntradasDesde = cantEntradasDesde;
            CantEntradasHasta = cantEntradasHasta;
            //CantEntradas=cantEntradas;
            IdComprobante = idComprobante;
            ImporteDesde = importeDesde;
            ImporteHasta = importeHasta;
        }
        public void AgregarTicket(Ticket ticket)
        {
            lTickets.Add(ticket);
        }
        public void QuitarTicket(int posicion)
        {
            lTickets.RemoveAt(posicion);
        }
    }
}
