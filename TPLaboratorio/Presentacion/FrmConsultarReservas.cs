using System;
using System.Data;
using System.Windows.Forms;
using TPLaboratorio.Servicio.Implementacion;
using TPLaboratorio.Servicio.Interfaz;

namespace TPLaboratorio.Presentacion
{
    public partial class FrmConsultarReservas : Form
    {

        IServicioConsultas servicio;

        public FrmConsultarReservas()
        {
            InitializeComponent();
            servicio = new ServicioConsultasImpl();
        }

        private void FrmConsultarReservas_Load(object sender, EventArgs e)
        {
            txtNombreReserva.Text = string.Empty;
            dtpFechaReserva.Value = DateTime.Today;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvReservas.Rows.Clear();
            DataTable tabla = servicio.TraerReservaFiltrada(txtNombreReserva.Text, dtpFechaReserva.Value);

            foreach (DataRow fila in tabla.Rows)
            {
                dgvReservas.Rows.Add(new object[] {
                    fila[0].ToString(),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    fila[3].ToString(),
                    fila[4].ToString(),
                    fila[5].ToString()
                });


            }

            if (dgvReservas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron reservas","Control",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            txtNombreReserva.Text = string.Empty;
            dtpFechaReserva.Value = DateTime.Today;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desesa salir?","Control",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
