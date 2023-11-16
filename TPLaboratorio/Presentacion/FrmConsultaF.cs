using System;
using System.Data;
using System.Windows.Forms;
using TPLaboratorio.Servicio.Implementacion;
using TPLaboratorio.Servicio.Interfaz;

namespace TPLaboratorio.Presentacion
{
    public partial class FrmConsultaF : Form
    {
        IServicioConsultas servicio;

        public FrmConsultaF()
        {
            InitializeComponent();
            servicio = new ServicioConsultasImpl();
        }

        private void FrmConsultaF_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now.AddDays(7);
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable tabla = servicio.TraerPeliculaFiltrada(dtpDesde.Value, dtpHasta.Value);
            DgvPelis.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                DgvPelis.Rows.Add(new object[] {
                    fila["nombre"].ToString(),
                     fila["total"].ToString(),
                    fila["cantidad"].ToString(),
                    fila["funciones"].ToString()
                });


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desesa salir?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
