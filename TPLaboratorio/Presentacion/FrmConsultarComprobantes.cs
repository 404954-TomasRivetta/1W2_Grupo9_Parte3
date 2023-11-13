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
            TraerComprobantes();
        }
        public bool ValidarDatos()
        {
            bool resultado = true;


            return resultado;
        }
        public void TraerComprobantes()
        {
            int idComp = Convert.ToInt32(txtComprobante.Text);
            int idCli = Convert.ToInt32(txtCliente.Text);
            int idFormaPago = Convert.ToInt32(txtFormaPago.Text);
            int idEmpleado = Convert.ToInt32(txtEmpleado.Text);
            int cantDesde = Convert.ToInt32(txtDesde.Text);
            int cantHasta = Convert.ToInt32(txtHasta.Text);
            try
            {               
                Comprobante c = new Comprobante(idCli, idFormaPago, idEmpleado, cantDesde, cantHasta, idComp);
                List<Comprobante> lComprobantes = servicio.TraerComprobantesFiltrados(c);

                foreach (Comprobante co in lComprobantes)
                {                    

                    dgvComprobantes.Rows.Add(new object[] { co.IdComprobante, co.NombreCliente, co.NombreEmpleado, co.FormaPago, co.CantEntradas });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al traer comprobantes: {ex.Message}", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
