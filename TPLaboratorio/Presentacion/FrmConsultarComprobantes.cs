using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPLaboratorio.Dominio;
using TPLaboratorio.Servicio.Implementacion;
using TPLaboratorio.Servicio.Interfaz;

namespace TPLaboratorio.Presentacion
{
    public partial class FrmConsultarComprobantes : Form
    {

        //Rodri
        IServicioConsultas servicio;
        public FrmConsultarComprobantes()
        {
            InitializeComponent();
            servicio = new ServicioConsultasImpl();
        }        
        private void FrmConsultaFunciones_Load(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            dgvComprobantes.Rows.Clear();
            TraerComprobantes();
        }
        public void ValidarDatos()
        {            
            if(!string.IsNullOrEmpty(txtComprobante.Text)&&!int.TryParse(txtComprobante.Text,out _))
            {
                MessageBox.Show("Debe ingresar un comprobante valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(txtCliente.Text) && !int.TryParse(txtCliente.Text, out _))
            {
                MessageBox.Show("Debe ingresar un cliente valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(txtEmpleado.Text) && !int.TryParse(txtEmpleado.Text, out _))
            {
                MessageBox.Show("Debe ingresar un empleado valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(txtFormaPago.Text) && !int.TryParse(txtFormaPago.Text, out _))
            {
                MessageBox.Show("Debe ingresar una forma de pago valida..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(txtDesde.Text) && !int.TryParse(txtDesde.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad de entradas valida..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(txtHasta.Text) && !int.TryParse(txtHasta.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad de entradas valida..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(txtDesdeImporte.Text) && !decimal.TryParse(txtDesdeImporte.Text, out _))
            {
                MessageBox.Show("Debe ingresar un importe valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(txtHastaImporte.Text) && !decimal.TryParse(txtHastaImporte.Text, out _))
            {
                MessageBox.Show("Debe ingresar un importe valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        public void TraerComprobantes()
        {
            try
            {
            int idComp, idCli, idFormaPago, idEmpleado, cantDesde, cantHasta;
            decimal importeDesde,importeHasta;

            if (!int.TryParse(txtComprobante.Text, out idComp))
            {
                idComp = 0; 
            }

            if (!int.TryParse(txtCliente.Text, out idCli))
            {
                idCli = 0; 
            }

            if (!int.TryParse(txtFormaPago.Text, out idFormaPago))
            {
                idFormaPago = 0; 
            }

            if (!int.TryParse(txtEmpleado.Text, out idEmpleado))
            {
                idEmpleado = 0; 
            }

            if (!int.TryParse(txtDesde.Text, out cantDesde))
            {
                cantDesde = 0; 
            }

            if (!int.TryParse(txtHasta.Text, out cantHasta))
            {
                cantHasta = 0; 
            }

            if (!decimal.TryParse(txtDesdeImporte.Text, out importeDesde))
            {
                importeDesde = 0;
            }

            if (!decimal.TryParse(txtHastaImporte.Text, out importeHasta))
            {
                importeHasta = 0;
            }

                Comprobante c = new Comprobante(idComp, idCli, idEmpleado, cantDesde, cantHasta, importeDesde,importeHasta);
                List<Comprobante> lComprobantes = servicio.TraerComprobantesFiltrados(c);

            foreach (Comprobante co in lComprobantes)
            {
                dgvComprobantes.Rows.Add(new object[] { co.IdComprobante, co.NombreCliente, co.NombreEmpleado, co.FormaPago, co.CantEntradas,co.Importe });
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show($"Error al traer comprobantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
    }
}
